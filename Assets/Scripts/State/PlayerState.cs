using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player{
    public abstract class PlayerState
    {
        protected readonly PlayerController _system;
        public PlayerState(PlayerController system){
            _system = system;
        }

        public virtual void Duck(){

        }
        
        public virtual void Jump(){

        }
    }
}

