
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class VideoplayerButton : UdonSharpBehaviour
{
    [SerializeField]
    private GameObject _videoPlayer;

    public override void Interact()
    {
        base.Interact();
        _videoPlayer.SetActive(!_videoPlayer.activeSelf);
    }
}
