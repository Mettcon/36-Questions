
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class LastQuestion : UdonSharpBehaviour
{
    public Questionhandler Questions;

    public override void Interact()
    {
        base.Interact();
        Questions.LastQuestion();
    }
}
