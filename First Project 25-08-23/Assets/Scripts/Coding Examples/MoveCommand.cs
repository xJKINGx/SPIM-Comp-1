using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClassLesson
{
    public class MoveCommand : ICommand
    {
        public void Execute()
        {
            Debug.Log(Mathf.PI);
        }
    }
}

