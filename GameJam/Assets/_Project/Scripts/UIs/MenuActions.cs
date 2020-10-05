namespace UI
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using GameBase;
    using TMPro;

    public class MenuActions : MonoBehaviour
    {
        public GameObject currentActive;
        public AudioClip buttonClick;
        public AudioSource audioPlayer;
        public TextMeshProUGUI scoreText;

        private void Start()
        {
            if(scoreText != null)
            {
                scoreText.text = GameManager.Instance.roundsSurvived.ToString();
            }
        }

        public void SwitchToScreen(GameObject nextScreen)
        {
            currentActive.SetActive(false);
            nextScreen.SetActive(true);
            currentActive = nextScreen;

            audioPlayer.PlayOneShot(buttonClick, 1f);
        }


        public void GoToScene(int sceneIndex)
        {
            audioPlayer.PlayOneShot(buttonClick, 1f);

            SceneManager.LoadScene(sceneIndex);
        }

        public void ResetGame(int sceneIndex)
        {
            GameManager.Instance.ResetSavedData();
            GoToScene(sceneIndex);
        }
    }

}