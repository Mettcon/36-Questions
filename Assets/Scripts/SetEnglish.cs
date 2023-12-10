
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class SetEnglish : UdonSharpBehaviour
{
    [SerializeField]
    private Questionhandler Questionhandler;

    public override void Interact()
    {
        base.Interact();
        Questionhandler.Language = "eng";
        Questionhandler.SetQuestion();
    }
}
