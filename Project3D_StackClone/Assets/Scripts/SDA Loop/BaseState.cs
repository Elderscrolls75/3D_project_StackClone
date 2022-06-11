using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SDA.Loop;

namespace SDA.Loop
{
    public interface IBaseState
    {
        //Start State
        void InitState();
        //Update State
        void UpdateState();
        //Exit State
        void DisposeState();

    }
}
