using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace SDA.Loop
{
    public class GameController : MonoBehaviour
    {
        private MenuState menuState;
        private GameState gameState;

        //delegate takes methods only without arguments
        private Action transitionToGameState;


        IBaseState currentlyActiveState;

        private void Start()
        {
            //"creates" artificial method without argument, which calls Change State
            transitionToGameState += () => ChangeState(gameState);


            menuState = new MenuState(transitionToGameState);
            gameState = new GameState();

            ChangeState(menuState);
        }


        private void Update()
        {
            //? = null check
            currentlyActiveState?.UpdateState();
        }

        private void OnDestroy()
        {
            
        }

        private void ChangeState(IBaseState newState)
        {
            //? = null check
            currentlyActiveState?.DisposeState();
            currentlyActiveState = newState;
            currentlyActiveState?.InitState();
        }

    }
}
