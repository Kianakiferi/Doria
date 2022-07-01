using Doria.URP.StateMachines;
using Doria.URP.StateMachines.CharacterStates;

namespace Doria.URP.States.CharacterStates.Player
{
    public abstract class PlayerStateBase : StateBase
    {
        protected PlayerStateMachine _stateMachine;

        public PlayerStateBase(PlayerStateMachine stateMachine)
        {
            this._stateMachine = stateMachine;
        }
    }


}
