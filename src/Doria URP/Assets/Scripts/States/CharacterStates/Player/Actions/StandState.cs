using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Doria.URP.StateMachines.CharacterStates;

namespace Doria.URP.States.CharacterStates.Player
{
    public class StandState
    {
    }

    public class IdleState : PlayerStateBase
    {
        public IdleState(PlayerStateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {

        }
        public override void Tick(float deltaTime)
        {

        }

        public override void Exit()
        {

        }
    }
}
