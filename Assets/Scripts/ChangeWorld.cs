
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ChangeWorld : UdonSharpBehaviour
{
    [SerializeField]
    private GameObject meadow;
    [SerializeField]
    private GameObject room;

    public override void Interact()
    {
        if (room.activeSelf)
        {
            room.SetActive(false);
            meadow.SetActive(true);
        } else
        {
            meadow.SetActive(false);
            room.SetActive(true);
        }
    }
}
