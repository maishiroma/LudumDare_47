namespace Events
{
    using System.Collections;
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using GameBase;
    using Terrain;
    using UnityEngine.UI;
    using UI;

    public class ConveyorBeltEvent : MonoBehaviour
    {
        private static ConveyorBeltMovement CB_CONTROLLER;

        public int eventIndex;
        public float newZoom;
        public float transitionSpeed;
        public Camera mainCamera;
        public AudioSource audioPlayer;
        public AudioClip eventActivate;

        public Image eyeEffect;
        public Image overlayEffect;
        public float screenTransitionTime;

        public ContextualVisuals mainUI;

        // private
        private float origZoom;

        private void Start()
        {
            if(CB_CONTROLLER == null)
            {
                CB_CONTROLLER = GameObject.FindObjectOfType<ConveyorBeltMovement>();
            }

            origZoom = mainCamera.orthographicSize;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.CompareTag("Player") && GameManager.Instance.playerClearedEvent == false)
            {
                CB_CONTROLLER.canMove = false;

                StartCoroutine(StartEvent(collision.transform.position));
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                if(GameManager.Instance.playerClearedEvent == true)
                {
                    GameManager.Instance.playerClearedEvent = false;
                }
            }
        }

        private IEnumerator StartEvent(Vector2 playerPos)
        {
            mainUI.customTextToDisplay = "Here comes trouble!";

            audioPlayer.Stop();
            audioPlayer.PlayOneShot(eventActivate, 0.5f);

            yield return new WaitForFixedUpdate();

            float cameraZAxis = mainCamera.transform.position.z;

            while(Vector2.Distance(playerPos, mainCamera.transform.position) >= 0.3f == true && mainCamera.orthographicSize >= newZoom)
            {
                Vector2 newPos = Vector2.Lerp(mainCamera.transform.position, playerPos, transitionSpeed * Time.deltaTime);
                mainCamera.transform.position = new Vector3(newPos.x, newPos.y, cameraZAxis);

                mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, newZoom, transitionSpeed * Time.deltaTime);

                ChangeAlphaOfOverlay();

                yield return new WaitForFixedUpdate();
            }

            GameManager.Instance.savedWayPointIndex = CB_CONTROLLER.GetCurrentPointIndex;

            // WIP
            SceneManager.LoadScene(eventIndex);
        }

        private void ChangeAlphaOfOverlay()
        {
            float alpha = Mathf.Lerp(eyeEffect.color.a, 1, screenTransitionTime * Time.deltaTime);
            Color newColor = new Color(eyeEffect.color.r, eyeEffect.color.g, eyeEffect.color.b, alpha);
            eyeEffect.color = newColor;

            alpha = Mathf.Lerp(overlayEffect.color.a, 0.5f, screenTransitionTime * Time.deltaTime);
            newColor = new Color(overlayEffect.color.r, overlayEffect.color.g, overlayEffect.color.b, alpha);
            overlayEffect.color = newColor;
        }
    }

}