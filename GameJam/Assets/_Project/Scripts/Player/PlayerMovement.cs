/* Controls the player movement
 * 
 */

namespace Player
{
    using UnityEngine;
    using GameBase;
    using UnityEngine.InputSystem;

    public class PlayerMovement : MonoBehaviour
    {        
        public float moveSpeed;
        public float stopSpeed;
        public float maxMoveSpeed;

        public Animator playerAnimations;

        // Private Vars
        private Rigidbody2D playerRB;
        private Vector2 movementInput;

        private InputActions controls;      // Ref to the controls input that we are using for the project

        public bool IsPlayerDead
        {
            get { return playerAnimations.GetBool("hasLost");  }
        }

        public bool IsPlayerWin
        {
            get { return playerAnimations.GetBool("hasWon");  }
        }

        // Activates all of the controls for the player
        private void Awake()
        {
            // We need to first set this to be a new object before we can do anything
            controls = new InputActions();

            // Then we can set up calllbacks to specific methods that we want the controls to listen to
            controls.Player.Movement.performed += ctx => GrabMovement(ctx);
            controls.Player.Movement.canceled += ctx => GrabMovement(ctx);
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
            movementInput = new Vector2();

            playerRB = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            if (IsPlayerDead == false & IsPlayerWin == false)
            {
                if (movementInput != Vector2.zero)
                {
                    Vector2 newVelocity = Vector2.ClampMagnitude(playerRB.velocity + movementInput, maxMoveSpeed);
                    playerRB.velocity = Vector2.Lerp(playerRB.velocity, newVelocity, moveSpeed * Time.deltaTime);
                }
                else
                {
                    playerRB.velocity = Vector2.Lerp(playerRB.velocity, Vector2.zero, stopSpeed * Time.deltaTime);
                }

                AnimatePlayerMovement();
            }
            else
            {
                playerRB.velocity = Vector2.Lerp(playerRB.velocity, Vector2.zero, stopSpeed * Time.deltaTime);
            }
        }

        private void GrabMovement(InputAction.CallbackContext ctx)
        {
            movementInput.x = ctx.ReadValue<Vector2>().x;
            movementInput.y = ctx.ReadValue<Vector2>().y;
        }

        private void AnimatePlayerMovement()
        {
            if(movementInput == Vector2.zero)
            {
                playerAnimations.SetFloat("Blend", 0f);
            }
            else if(movementInput.y != 0)
            {
                switch (Mathf.Sign(movementInput.y))
                {
                    case -1:
                        playerAnimations.SetFloat("Blend", 0.5f);
                        break;
                    case 1:
                        playerAnimations.SetFloat("Blend", 0.25f);
                        break;
                }
            }
            else
            {
                switch(Mathf.Sign(movementInput.x))
                {
                    case -1:
                        playerAnimations.SetFloat("Blend", 0.75f);
                        break;
                    case 1:
                        playerAnimations.SetFloat("Blend", 1f);
                        break;
                }
            }
        }
    }

}