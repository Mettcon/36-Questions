
using System;
using System.Data;
using System.Drawing.Text;
using System.Globalization;
using TMPro;
using UdonSharp;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using VRC.SDK3.Data;
using VRC.SDKBase;
using VRC.Udon;

public class Questionhandler : UdonSharpBehaviour
{

    //TODO: think of some better names
    [SerializeField]
    private TextAsset questionsFile;
    private DataDictionary questions;

    private VRCPlayerApi _player;
    [SerializeField]
    private TextMeshProUGUI Screen;

    // those do not change at runtime, so we do it here ones
    // they rarely change so we can hardcode them an save as const.
    private int _QuestionsLength;
    private int _Introlength;

    [UdonSynced]
    private int iterator = 0;
    private readonly string[] languages = { "en", "de", "zh" };
    internal readonly string[] States = { "Intro", "Questions" };

    private string _language = "en";
    internal string Language
    {
        get => _language;
        set
        {
            
            foreach (string entry in languages)
            {
                if (entry.Equals(value))
                {
                    _language = value;
                    SetQuestion();
                    return;
                }
            }

            Debug.LogError($"Language '{value}' is not available.");
            _language = "en";

        }
    }

    private string _state = "Intro";
    internal string State
    {
        get => _state;
        set
        {
            foreach (var state in States)
            {
                if (state.Equals(value))
                {
                    _state = value;
                    iterator = 0;
                    SetQuestion();
                    RequestSerialization();
                    return;
                }
            }

            Debug.LogError($"State '{value}' is not available.");
            _state = "Intro";
            SetQuestion();
        }
    }

    private void Start()
    {
        string jsonString = questionsFile.text;

        if (!VRCJson.TryDeserializeFromJson(jsonString, out DataToken temp))
        {
            UnityEngine.Debug.LogError("Failed to read Json");
            // return here?
        };
        questions = temp.DataDictionary;
        _Introlength = questions[States[0]].DataList.Count;
        _QuestionsLength = questions[States[1]].DataList.Count;

        _player = Networking.LocalPlayer;
        SetQuestion();
    }


    internal void SetQuestion()
    {
        Screen.text = questions[State].DataList[iterator].DataDictionary[Language].ToString();
    }

    /*
    internal void SetQuestion()
    {
        DataToken set;
        switch (Language)
        {
            case Languages.zh:
                switch (State)
                {
                    case States.Intro:
                        intro.Sets.TryGetValue("Chinese", TokenType.DataList, out set);
                        Screen.text = set.DataList[iterator].String;
                        break;

                    case States.Questions:

                        questions.Sets.TryGetValue("Chinese", TokenType.DataList, out set);
                        Screen.text = set.DataList[iterator].ToString();
                        break;

                    default:
                        UnityEngine.Debug.Log("This should never happen");
                        break;
                }
                break;

            case Languages.de:
                switch (State)
                {
                    case States.Intro:
                        intro.Sets.TryGetValue("German", TokenType.DataList, out set);
                        Screen.text = set.DataList[iterator].String;
                        break;

                    case States.Questions:
                        questions.Sets.TryGetValue("German", TokenType.DataList, out set);
                        Screen.text = set.DataList[iterator].String;
                        break;

                    default:
                        UnityEngine.Debug.Log("This should never happen");
                        break;
                }
                break;

            default:
                switch (State)
                {
                    case States.Intro:
                        intro.Sets.TryGetValue("English", TokenType.DataList, out set);
                        Screen.text = set.DataList[iterator].String;
                        break;

                    case States.Questions:
                        questions.Sets.TryGetValue("English", TokenType.DataList, out set);
                        Screen.text = set.DataList[iterator].ToString();
                        break;

                    default:
                        UnityEngine.Debug.Log("This should never happen");
                        break;
                }
                break;
        }
    }
    */

    public void TestDropDown(int val)
    {
        Debug.LogWarning($"Dropdown fired with {val}");
    }

    public void SetIntroduction()
    {
        
        if (!_player.IsOwner(gameObject))
        {
            Networking.SetOwner(_player, gameObject);
        }
        
        iterator = 0;
        State = States[0];
        SetQuestion();
        RequestSerialization();
    }

    public void SetQuestions()
    {
         
        if (!_player.IsOwner(gameObject))
        {
            Networking.SetOwner(_player, gameObject);
        }

        iterator = 0;
        State = States[1];
        SetQuestion();
        RequestSerialization();
    }

    public void NextQuestion()
    {
        if (!_player.IsOwner(gameObject))
        {
            Networking.SetOwner(_player, gameObject);
        }
        
        iterator++;

        switch (State)
        {
            case "Intro":
                if (iterator >= _Introlength) { iterator = 0; }
                break;

            case "Questions":
                if (iterator >= _QuestionsLength) { iterator = 0; }
                break;

            default:
                UnityEngine.Debug.Log("should never happen");
                break;
        }
        SetQuestion();
        RequestSerialization();
    }

    public void LastQuestion()
    {
        Networking.SetOwner(_player, gameObject);
        iterator--;
        switch (State)
        {
            case "Intro":
                if (iterator < 0) { iterator = _Introlength - 1; }
                break;

            case "Questions":
                if (iterator < 0) { iterator = _QuestionsLength - 1; }
                break;

            default:
                UnityEngine.Debug.Log("should never happen");
                break;
        }
        SetQuestion();
        RequestSerialization();
    }



    public override void OnDeserialization()
    {
        base.OnDeserialization();
        SetQuestion();
    }
}

public enum Languages
{
    zh,
    en,
    de
}