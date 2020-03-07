/*
 * Matt Kirchoff
 * MoveCommand2.cs
 * CIS452 Assignment 7
 * Move command to the 2nd move object
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace CIS452_Assignment7
{
    public class MoveCommand2 : Command
    {
        Move2 move2;

        public Stack<Vector3> positionHistory2;

        public MoveCommand2(Move2 move2)
        {
            this.move2 = move2;
            positionHistory2 = new Stack<Vector3>();
        }

        public void Execute(Vector3 point)
        {
            positionHistory2.Push(move2.GetCurrentPosition());

            move2.MoveCommand2(point);
        }

        public void Undo()
        {


            //Instead, we will assign the Vector3 position in our stack to our gameObject
            if (positionHistory2 != null)
            {
                move2.MoveCommand2(positionHistory2.Pop());
            }

        }

    }
}

