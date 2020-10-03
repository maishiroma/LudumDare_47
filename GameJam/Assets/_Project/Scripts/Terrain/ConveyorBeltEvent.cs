namespace Environment
{
    using System.Collections;
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using GameBase;

    public class ConveyorBeltEvent : MonoBehaviour
    {
        private static ConveyorBeltMovement CB_CONTROLLER;

        public int eventIndex;
        public float newZoom;
        public float transitionSpeed;
        public Camera mainCamera;

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
            float cameraZAxis = mainCamera.transform.position.z;

            while(Vector2.Distance(playerPos, mainCamera.transform.position) > 0.1f == true && mainCamera.orthographicSize > newZoom)
            {
                Vector2 newPos = Vector2.Lerp(mainCamera.transform.position, playerPos, transitionSpeed * Time.deltaTime);
                mainCamera.transform.position = new Vector3(newPos.x, newPos.y, cameraZAxis);

                mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, newZoom, transitionSpeed * Time.deltaTime);

                yield return new WaitForEndOfFrame();
            }

            GameBase.GameManager.Instance.savedWayPointIndex = CB_CONTROLLER.GetCurrentPointIndex;

            // WIP
            SceneManager.LoadScene(eventIndex);
        }

    }

}