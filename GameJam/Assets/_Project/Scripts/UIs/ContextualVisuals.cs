namespace UI
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using GameBase;
    using TMPro;

    public class ContextualVisuals : MonoBehaviour
    {
        public TextMeshProUGUI mainBodyText;
        public TextMeshProUGUI scoreText;
        public string customTextToDisplay;

        private void Update()
        {
            scoreText.text = "Round " + GameManager.Instance.roundsSurvived.ToString();
            mainBodyText.text = customTextToDisplay;
        }
    }

}