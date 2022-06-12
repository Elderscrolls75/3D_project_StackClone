using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using SDA.UI;

namespace SDA.Loop
{

    public class MenuState : IBaseState
    {
        private Action transitionToGameState;
        private MenuView menuView;
        public MenuState(Action transitionToGameState, MenuView menuView)
        {
            this.transitionToGameState = transitionToGameState;
            this.menuView = menuView;
        }
        public void InitState()
        {
            menuView.ShowView();
        }


        public void UpdateState()
        {
            Debug.Log("dupa");
        }

        public void DisposeState()
        {
            menuView.HideView();
        }
    }
}
