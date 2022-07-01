
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Doria.URP.States;

namespace Doria.URP.StateMachines
{
    public abstract class StateMachine : MonoBehaviour
    {
        private StateBase _currentState;

        public void SwitchState(StateBase newState)
        {
            if (_currentState is not null)
            {
                _currentState.Exit();

                
            }

            _currentState = newState;
            _currentState.Enter();
        }

        private void Update()
        {
            if (_currentState is not null)
            {
                _currentState.Tick(Time.deltaTime);
            }
        }

    }
}
