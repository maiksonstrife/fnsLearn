using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player {

    public class PlayerController : MonoBehaviour
    {
        private PlayerState _currentState;
        // Start is called before the first frame update

        public void SetState (PlayerState currentstate){
            _currentState = currentstate;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                SetState(new JumpState(this));
            }

            if (Input.GetKey(KeyCode.S))
            {
                SetState(new DuckState(this));
            }
        }
    }
}
