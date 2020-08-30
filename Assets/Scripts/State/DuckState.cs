using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player{

    public class DuckState : PlayerState
    {
        public DuckState(PlayerController system) : base(system)
        {

        }

        public override void Duck()
        {
            Debug.Log("Ducked");
            _system.SetState(new JumpState(_system));
        }
    }
}

