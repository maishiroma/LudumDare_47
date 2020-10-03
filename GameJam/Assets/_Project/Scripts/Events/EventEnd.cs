namespace Events
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using GameBase;

    public class EventEnd : MonoBehaviour
    {
        public int eventIndex;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                StartCoroutine(StartEvent(collision.transform.position));
            }

        }

        private IEnumerator StartEvent(Vector2 playerPos)
        {
            yield return new WaitForSeconds(3f);
            GameManager.Instance.playerClearedEvent = true;

            // WIP
            SceneManager.LoadScene(eventIndex);
        }


    }

}