using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassLesson
{
    public class PrintSinusCommand : ICommand
    {
        public void Execute()
        {
            Debug.Log(MathF.Sin(Mathf.PI*3/2));
        }
    }
}

