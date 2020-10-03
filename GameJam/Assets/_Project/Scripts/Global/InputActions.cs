// GENERATED AUTOMATICALLY FROM 'Assets/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace GameBase
{
    public class @InputActions : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""eac3d7d5-4641-49a3-bab9-f249ad8c38a1"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""9de1f341-3abb-4e73-9f3f-603bef4004d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse Movement"",
                    ""type"": ""Value"",
                    ""id"": ""d8129662-40f5-47b7-abb1-58dbdab915a4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse Selection"",
                    ""type"": ""Button"",
                    ""id"": ""86cd6b69-5b85-4311-bab7-8206d59a8160"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""3d9d35b2-3731-4930-a552-08500f22eb5e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6351091e-0593-4eb1-a056-e8da1a2e59e3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a779d5f8-7d59-4691-bb40-600eb9aed17a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""488ad8a8-4565-44bf-9639-6d7ebcc6bef9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e170f037-c3d6-4c31-8010-df2f18b2aa45"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""7866a5d6-fb71-483a-9380-aac5ba9f38cd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""410fd39b-371e-4352-b8a1-a58883642305"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3d7008ad-f834-4975-9c71-7aaf0e5b1e28"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c1e10c30-f69a-46e4-a66d-df6c50500183"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""83e75caa-5f6c-4892-a8eb-fcfade32b5f2"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""73d5cf50-b9e2-44fc-bd55-de4a0bde9437"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""Mouse Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d0336d8-398d-4297-82c5-758a881ca257"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Computer"",
                    ""action"": ""Mouse Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Computer"",
            ""bindingGroup"": ""Computer"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
            m_Player_MouseMovement = m_Player.FindAction("Mouse Movement", throwIfNotFound: true);
            m_Player_MouseSelection = m_Player.FindAction("Mouse Selection", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // Player
        private readonly InputActionMap m_Player;
        private IPlayerActions m_PlayerActionsCallbackInterface;
        private readonly InputAction m_Player_Movement;
        private readonly InputAction m_Player_MouseMovement;
        private readonly InputAction m_Player_MouseSelection;
        public struct PlayerActions
        {
            private @InputActions m_Wrapper;
            public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_Player_Movement;
            public InputAction @MouseMovement => m_Wrapper.m_Player_MouseMovement;
            public InputAction @MouseSelection => m_Wrapper.m_Player_MouseSelection;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                    @MouseMovement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseMovement;
                    @MouseMovement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseMovement;
                    @MouseMovement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseMovement;
                    @MouseSelection.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseSelection;
                    @MouseSelection.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseSelection;
                    @MouseSelection.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseSelection;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @MouseMovement.started += instance.OnMouseMovement;
                    @MouseMovement.performed += instance.OnMouseMovement;
                    @MouseMovement.canceled += instance.OnMouseMovement;
                    @MouseSelection.started += instance.OnMouseSelection;
                    @MouseSelection.performed += instance.OnMouseSelection;
                    @MouseSelection.canceled += instance.OnMouseSelection;
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);
        private int m_ComputerSchemeIndex = -1;
        public InputControlScheme ComputerScheme
        {
            get
            {
                if (m_ComputerSchemeIndex == -1) m_ComputerSchemeIndex = asset.FindControlSchemeIndex("Computer");
                return asset.controlSchemes[m_ComputerSchemeIndex];
            }
        }
        public interface IPlayerActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnMouseMovement(InputAction.CallbackContext context);
            void OnMouseSelection(InputAction.CallbackContext context);
        }
    }
}
