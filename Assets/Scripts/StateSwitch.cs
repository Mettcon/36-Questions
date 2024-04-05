
using System.ComponentModel;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class StateSwitch : UdonSharpBehaviour
{
    private Dropdown dropdown;
    [SerializeField]
    private Questionhandler questionhandler;
    void Start()
    {
        // Abrufen der Dropdown-Komponente, die sich am selben GameObject befindet
        dropdown = GetComponent<Dropdown>();
    }

    public void SetState()
    {
        questionhandler.TestDropDown(dropdown.value);
    }


}
