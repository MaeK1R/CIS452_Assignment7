using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Invoker : MonoBehaviour
{
    //To review C# collections like Dictionaries and Stacks
    //see http://www.newthinktank.com/2017/02/c-tutorial-11/

    Dictionary<Vector3, Command> commands;
    Command undoCommand;
    Stack<Command> commandHistory;
    static int counter;


    public Invoker()
    {
        commands = new Dictionary<Vector3, Command>();
        commandHistory = new Stack<Command>();

    }

    public void AddCommand(Vector3 vector3, Command command)
    {
        commands.Add(vector3, command);
    }

    public void InvokeOrPressRemoteButton(Vector3 vector3)
    {
        //Try to get the command with the slotName
        commands.TryGetValue(vector3, out Command command);
        //Call execute on command if command is not null
        if (command != null) { command.Execute(); }

        //set undoCommand to command - undoCommand is not currently used
        undoCommand = command;

        //Add command to command history stack
        commandHistory.Push(command);
    }

    public void InvokeUndoOrPressUndoButton()
    {
        if (commandHistory.Count != 0)
        {
            Debug.Log("Undoing...");
            Command command = commandHistory.Pop();
            command.Undo();
        }
        else
        {
            Debug.Log("You tried to undo, but there are no more commands to undo.");
        }
    }

    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {

        }
    }

}
