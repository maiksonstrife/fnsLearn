using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player{
    public class JumpState : PlayerState
    {
        public JumpState(PlayerController system) : base(system)
        {

        }

        public override void Jump()
        {
            Debug.Log("Jumped");
        }
    }
}
