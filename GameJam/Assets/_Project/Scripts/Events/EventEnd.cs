﻿namespace Events
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using GameBase;
    using UI;

    public class EventEnd : MonoBehaviour
    {
        public int eventIndex;
        public AudioSource audioPlayer;
        public AudioClip winSound;
        public ContextualVisuals mainUI;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                collision.GetComponentInChildren<Animator>().SetBool("hasWon", true); 
                StartCoroutine(StartEvent(collision.transform.position));
            }
        }

        private IEnumerator StartEvent(Vector2 playerPos)
        {
            mainUI.customTextToDisplay = "Successful escape!";

            audioPlayer.Stop();
            audioPlayer.PlayOneShot(winSound, 0.5f);
            yield return new WaitForFixedUpdate();

            GameManager.Instance.playerClearedEvent = true;
            GameManager.Instance.roundsSurvived++;

            yield return new WaitForSeconds(1f);
            // WIP
            SceneManager.LoadScene(eventIndex);
        }


    }

}