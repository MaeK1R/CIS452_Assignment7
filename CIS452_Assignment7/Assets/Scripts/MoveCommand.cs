using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveCommand : Command
{
    private Vector3 position;

    public MoveCommand(Vector3 vector3)
    {
        this.position = vector3;
    }

    public void Execute()
    {
        Move.MovePlayer(position);
    }

    public void Undo()
    {
       
    }
}
