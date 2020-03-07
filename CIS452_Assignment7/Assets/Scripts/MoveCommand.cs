/*
 * Matt Kirchoff
 * MoveCommand.cs
 * CIS452 Assignment 7
 * Move command to the move object
 */
 using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace CIS452_Assignment7
{
    public class MoveCommand : Command
    {
        Move move;

        Stack<Vector3> positionHistory;

        public MoveCommand(Move move)
        {
            this.move = move;
            positionHistory = new Stack<Vector3>();
        }

        public void Execute(Vector3 point)
        {
            positionHistory.Push(move.GetCurrentPosition());

            move.MoveCommand(point);

        }

        public void Undo()
        {


            //Instead, we will assign the Vector3 position in our stack to our gameObject
            if (positionHistory != null)
            {
                move.MoveCommand(positionHistory.Pop());
            }

        }


    }

}