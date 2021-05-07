using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SC_DialogLineList", menuName = "Custom/DialogLines", order = 145)]
public class DialogLineList : ScriptableObject
{
    public Dictionary<string, DialogLine> dialogLines;
}

public class DialogLine
{
    public string lineCode;
    public string scene;
    public string character;
    public string text;

    public AudioClip voice;
    //volume
    //delay
    public AnimationClip anim;

    public DialogLine()
    {
    lineCode = "NONE";
    scene = "NONE";
    character = "NONE";
    text = "NONE";
    }
}
