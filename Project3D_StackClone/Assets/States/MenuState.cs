using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace SDA.Loop
{

    public class MenuState : IBaseState
    {
        private Action transitionToGameState;
        public MenuState(Action transitionToGameState)
        {
            this.transitionToGameState = transitionToGameState;
        }
        public void InitState()
        {
            
        }


        public void UpdateState()
        {
            Debug.Log("dupa");

            if (Input.GetKeyDown(KeyCode.Space))
            {
                transitionToGameState.Invoke();
            }
        }

        public void DisposeState()
        {
            
        }
    }
}
