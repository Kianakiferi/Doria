using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Doria.URP.Actions.CharacterActions
{
    public abstract class CharacterActionBase
    {
        public virtual void Execute(GameObject actor);
    }
}
