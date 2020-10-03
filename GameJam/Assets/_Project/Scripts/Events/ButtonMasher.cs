namespace Events
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using GameBase;
    using UnityEngine.InputSystem;
    using TMPro;
    using UnityEngine.SceneManagement;

    public class ButtonMasher : MonoBehaviour
    {
        public int mainLevel;
        public int gameOver;

        public int minTimeToSurvive;
        public int maxTimeToSurivive;

        public int minOpponentStrength;
        public int maxOpponentStrength;

        public float minOpponentAttackRate;
        public float maxOpponentAttackRate;

        public TextMeshProUGUI mainMessage;
        public TextMeshProUGUI timeRemaining_text;
        public TextMeshProUGUI currentHealth_text;

        // Private Variables
        private bool eventDone = false;

        private InputActions controls;      // Ref to the controls input that we are using for the project
        private bool didMouseClick;

        private int opponentStrength;
        private int timeRequirement;
        private float opponentAttackRate;

        private float timePassed;
        private int currHealth;

        private void Awake()
        {
            // We need to first set this to be a new object before we can do anything
            controls = new InputActions();

            controls.Player.MouseSelection.performed += ctx => GrabMouseSelect(ctx);
            controls.Player.MouseSelection.canceled += ctx => GrabMouseSelect(ctx);
        }

        // Enables the controls when the player is active
        private void OnEnable()
        {
            controls.Enable();
        }

        // Diables the controls when the player is not active
        private void OnDisable()
        {
            controls.Disable();
        }

        private void Start()
        {
            timeRequirement = Random.Range(minTimeToSurvive, maxTimeToSurivive);
            opponentStrength = Random.Range(minOpponentStrength, maxOpponentStrength);
            opponentAttackRate = Random.Range(minOpponentAttackRate, maxOpponentAttackRate);

            currHealth = 100;

            mainMessage.text = "Resist getting taken!!!!";

            InvokeRepeating("LoseHealth", 0f, opponentAttackRate);
        }

        private void Update()
        {
           if(eventDone == false)
           {
                currentHealth_text.text = "Strength: " + currHealth.ToString();
                timeRemaining_text.text = "Time: " + ((int)timePassed).ToString() + "/" + ((int)timeRequirement).ToString();

                if (timePassed < timeRequirement)
                {
                    timePassed += Time.deltaTime;
                }
                else
                {
                    StartCoroutine(ClearEvent());
                    eventDone = true;
                    return;
                }
           }
        }

        private void LoseHealth()
        {
            if (eventDone == false)
            {
                if (currHealth > 0)
                {
                    currHealth -= Random.Range(1, opponentStrength);
                }
                else
                {
                    eventDone = true;
                    CancelInvoke("LoseHealth");
                    StartCoroutine(LoseEvent());
                }
            }
        }

        private void GrabMouseSelect(InputAction.CallbackContext ctx)
        {
            if(ctx.ReadValueAsButton() == false && didMouseClick == true)
            {
                currHealth++;
            }

            didMouseClick = ctx.ReadValueAsButton();
        }

        private IEnumerator ClearEvent()
        {
            mainMessage.text = "Congrats, you arre safe!";
            currentHealth_text.text = "";
            timeRemaining_text.text = "";

            yield return new WaitForSeconds(3f);


            GameManager.Instance.playerClearedEvent = true;

            // WIP
            SceneManager.LoadScene(mainLevel);
        }
        
        private IEnumerator LoseEvent()
        {
            mainMessage.text = "Yikes! You got pulled in!";
            currentHealth_text.text = "";
            timeRemaining_text.text = "";

            yield return new WaitForSeconds(3f);


            GameManager.Instance.ResetSavedData();

            // WIP
            SceneManager.LoadScene(gameOver);
        }

    }
}