using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Doria.URP.Scripts.Actions
{
    public class InputManager : MonoBehaviour, Controls.IPlayerActions
    {
        public event Action OnJumpEvent;
        public event Action OnSneakEvent;

        public Vector2 MovementVector2 { get; private set; }

        private Controls _controls;

        // Start is called before the first frame update

        void Start()
        {
            _controls = new();
            _controls.Player.SetCallbacks(this);

            _controls.Player.Enable();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnDestroy()
        {
            _controls.Disable();
        }
        

        public void OnAttackDestory(InputAction.CallbackContext context)
        {
            //throw new System.NotImplementedException();
        }
        public void OnUsePlace(InputAction.CallbackContext context)
        {
            //throw new System.NotImplementedException();
        }

        public void OnDropItem(InputAction.CallbackContext context)
        {
            //throw new System.NotImplementedException();
        }
        public void OnPickBlock(InputAction.CallbackContext context)
        {
            //throw new System.NotImplementedException();
        }

        public void OnInventory(InputAction.CallbackContext context)
        {
            //throw new System.NotImplementedException();
        }
        public void OnLook(InputAction.CallbackContext context)
        {

        }
        public void OnOrder(InputAction.CallbackContext context)
        {
            //throw new NotImplementedException();
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            MovementVector2 = context.ReadValue<Vector2>();
        }

        public void OnJump(InputAction.CallbackContext context)
        {
            if (!context.performed)
            {
                return;
            }

            if(OnJumpEvent is not null)
            {
                OnJumpEvent.Invoke();
            }

        }

        public void OnSneak(InputAction.CallbackContext context)
        {
            if (!context.performed)
            {
                return;
            }

            if (OnSneakEvent is not null)
            {
                OnSneakEvent.Invoke();
            }
        }

        public void OnSprint(InputAction.CallbackContext context)
        {
            //throw new System.NotImplementedException();
        }

        public void OnCrawl(InputAction.CallbackContext context)
        {
           //throw new NotImplementedException();
        }

        public void OnOpenChat(InputAction.CallbackContext context)
        {
            //throw new System.NotImplementedException();
        }

        public void OnOpenCommand(InputAction.CallbackContext context)
        {
            //throw new System.NotImplementedException();
        }

  
    }

}
