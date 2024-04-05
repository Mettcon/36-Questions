using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VRC.SDK3.Data;

internal enum States
{
    Intro,
    Questions
}

/*

class CurrentState
{
    States State { get; set; }
    DataDictionary Sets { get; set; }
    void SetState(States state)
    {
        State = state;
        switch (state)
        {
            case States.Intro:
                State = state;
                Sets = Intro.Sets;
                break;

            case States.Questions:
                State = state;
                Sets = Questions.Sets;
                break;

            default:
                UnityEngine.Debug.Log("This should never happen.");
                break;
        }
    }
}

*/