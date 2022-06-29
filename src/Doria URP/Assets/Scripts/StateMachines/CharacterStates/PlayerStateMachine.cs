using System;
using System.Collections.Generic;
using UnityEngine;

using Doria.URP.Scripts.Actions;
using Doria.URP.Scripts.States.CharacterStates.Player;

namespace Doria.URP.Scripts.StateMachines.CharacterStates
{
    public class PlayerStateMachine : StateMachine
    {
        [field: SerializeField]  public InputManager InputManager { get; private set; }
        [field: SerializeField]  public CharacterController CharacterController { get; private set; }
        [field: SerializeField]  public Animator Animator { get; private set; }
        [field: SerializeField]  public float FreeLookMovementValue { get; private set; }
        [field: SerializeField]  public float RotationDampingValue { get; private set; }

        public Transform CameraMainTransform { get; private set; }

        public void Start()
        {
            CameraMainTransform = Camera.main.transform;
            
            SwitchState(new PlayerFreeLookState(this));

            Debug.Log("Player State Machine Start");
        }
    }
}
