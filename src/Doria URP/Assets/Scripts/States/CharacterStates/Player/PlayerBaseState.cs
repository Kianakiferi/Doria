using Doria.URP.Scripts.StateMachines;
using Doria.URP.Scripts.StateMachines.CharacterStates;

namespace Doria.URP.Scripts.States.CharacterStates.Player
{
    public abstract class PlayerBaseState : StateBase
    {
        protected PlayerStateMachine _stateMachine;

        public PlayerBaseState(PlayerStateMachine stateMachine)
        {
            this._stateMachine = stateMachine;
        }
    }


}
