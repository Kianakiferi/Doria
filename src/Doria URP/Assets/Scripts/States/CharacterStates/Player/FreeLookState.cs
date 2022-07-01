using System;
using System.Collections.Generic;

using UnityEngine;

using Doria.URP.StateMachines.CharacterStates;
namespace Doria.URP.States.CharacterStates.Player
{
    public class FreeLookState : PlayerStateBase
    {
        private readonly int animatorParameterId_FreeLookSpeed = Animator.StringToHash("FreeLookSpeedBlend");

        private const float animatorDampTime = 0.1f;

        public FreeLookState(PlayerStateMachine stateMachine) : base(stateMachine)
        {

        }

        public override void Enter()
        {
            Debug.Log("PlayerTestState: Enter.");

        }
        public override void Tick(float deltaTime)
        {
            if (_stateMachine.InputManager.MovementVector2 == Vector2.zero)
            {
                SetAnimator(deltaTime, 0);

                return;
            }
  
            Vector3 newPostion = CaculateMovement();

            Move(deltaTime, newPostion);

            FaceMovementDirection(deltaTime, newPostion);

            SetAnimator(deltaTime, 0.5f);
        }



        public override void Exit()
        {
            Debug.Log("PlayerTestState: Exit.");
        }

        private Vector3 CaculateMovement()
        {
            var forward = _stateMachine.CameraMainTransform.forward;
            var right = _stateMachine.CameraMainTransform.right;

            forward.y = 0f;
            right.y = 0f;

            forward.Normalize();
            right.Normalize();

            return (forward * _stateMachine.InputManager.MovementVector2.y) +
                (right * _stateMachine.InputManager.MovementVector2.x);
        }

        private void Move(float deltaTime, Vector3 newPostion)
        {
            _stateMachine.CharacterController.Move(newPostion * _stateMachine.FreeLookMovementValue * deltaTime);
        }

        private void FaceMovementDirection(float deltaTime, Vector3 newPostion)
        {
            //_stateMachine.transform.rotation = Quaternion.LookRotation(newPostion);

            _stateMachine.transform.rotation = Quaternion.Lerp
            (
                _stateMachine.transform.rotation,
                Quaternion.LookRotation(newPostion),
                deltaTime * _stateMachine.RotationDampingValue
            );
        }

        private void SetAnimator(float deltaTime, float value)
        {
            _stateMachine.Animator.SetFloat(animatorParameterId_FreeLookSpeed, value, animatorDampTime, deltaTime);
        }
    }

}
