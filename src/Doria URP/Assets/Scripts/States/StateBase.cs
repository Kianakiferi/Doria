using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Doria.URP.States
{
    public abstract class StateBase
    {
        public abstract void Enter();
        public abstract void Tick(float deltaTime);
        public abstract void Exit();
    }
}
