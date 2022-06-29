
using Doria.URP.Scripts.StateMachines;
using Doria.URP.Scripts.StateMachines.CharacterStates;
using UnityEngine;

namespace Doria.URP.Scripts.States.CharacterStates.Player
{
    public class PlayerIdleState : PlayerBaseState
    {
        public PlayerIdleState(PlayerStateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            Debug.Log("PlayerIdleState: Enter.");
        }
        public override void Tick(float deltaTime)
        {
            Debug.Log("PlayerIdleState: Tick.");
        }

        public override void Exit()
        {
            Debug.Log("PlayerIdleState: Exit.");
        }
    }

}
