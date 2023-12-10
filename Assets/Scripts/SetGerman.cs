
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class SetGerman : UdonSharpBehaviour
{
    [SerializeField]
    private Questionhandler Questionhandler;

    public override void Interact()
    {
        base.Interact();
        Questionhandler.Language = "ger";
        Questionhandler.SetQuestion();
    }
}
