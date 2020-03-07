/*
 * Matt Kirchoff
 * Invoker.cs
 * CIS452 Assignment 7
 * Invoker to commands player does
 */
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace CIS452_Assignment7
{
    public class Invoker : MonoBehaviour
    {
        public Move move;
        public Move2 move2;
        private Command moveCommand;
        private Command moveCommand2;

        //Note that this is not using the stack or dictionary of commands - you may need to implement those
        //private List<Command> commandHistory;

        // Use this for initialization
        void Start()
        {
            //creating the instance of the MoveToPoint command and passing in the receiver to its constructor
            moveCommand = new MoveCommand(move);
            moveCommand2 = new MoveCommand2(move2);

            //commandHistory = new List<Command>();



        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {

                    //instead of this...
                    //agent.SetDestination(hit.point);

                    //call execute on our command class
                    moveCommand.Execute(hit.point);


                }


            }

            if (Input.GetMouseButtonDown(1))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {

                    //instead of this...
                    //agent.SetDestination(hit.point);

                    //call execute on our command class
                    moveCommand2.Execute(hit.point);


                }


            }

            if (Input.GetKeyDown(KeyCode.R))
            {

                moveCommand.Undo();
                moveCommand2.Undo();
            }

        }

    }
}