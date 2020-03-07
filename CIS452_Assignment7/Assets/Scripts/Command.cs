/*
 * Matt Kirchoff
 * Command.cs
 * CIS452 Assignment 7
 * Command interface
 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CIS452_Assignment7
{
    public interface Command
    {
        void Execute(Vector3 point);
        void Undo();
    }
}

