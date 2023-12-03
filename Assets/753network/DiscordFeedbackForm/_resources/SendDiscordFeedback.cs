using UnityEngine;
using UnityEngine.UI;
using UdonSharp;
using VRC.SDKBase;
using VRC.SDK3.Components;
using VRC.SDK3.Video.Components;
using VRC.SDK3.Video.Components.AVPro;

public class SendDiscordFeedback : UdonSharpBehaviour
{
    public Text APIURLText;
    public InputField playerInput;
    public InputField transitionInput;
    public VRCUrlInputField actualInput;
    public Animator animateOnSubmit;

    private int combo;
    private string apiURL;
    private string message;
    private string playerName;

    private VRCUrl emptyURL = new VRCUrl("");

    public void Start()
    {
        combo = 0;
        apiURL = APIURLText.text;
        playerName = Networking.LocalPlayer.displayName.Replace(' ', '_').Replace('~', '�').Replace('%', '�').Replace('\"', '�').Replace('@', '�').Replace('#', '�').Replace('&', '�').Replace('\\', '�');
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            message = playerInput.text;
            if (Input.GetKey(KeyCode.A) && combo >= 0 && message.Length > 0)
            {
                transitionInput.text = apiURL + playerName + ":_" + message.Replace(' ', '_').Replace('~', '�').Replace('%', '�').Replace('\"', '�').Replace('@', '�').Replace('#', '�').Replace('&', '�').Replace('\\', '�');
                transitionInput.Select();

                combo = 1;
            }
            else if (Input.GetKey(KeyCode.C) && combo == 1)
            {
                actualInput.SetUrl(emptyURL);
                actualInput.Select();

                combo = 2;
            }
            else if (Input.GetKey(KeyCode.V) && combo == 2)
            {

                actualInput.interactable = false;
                ((VRCUnityVideoPlayer)actualInput.GetComponent(typeof(VRCUnityVideoPlayer))).PlayURL(actualInput.GetUrl());
                animateOnSubmit.enabled = true;

                combo = -1;
            }
        }
    }
}