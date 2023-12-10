
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class SetChinese : UdonSharpBehaviour
{
    [SerializeField]
    private Questionhandler Questionhandler;

    public override void Interact()
    {
        base.Interact();
        Questionhandler.Language = "chi";
        Questionhandler.SetQuestion();
    }
}
