using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SC_DialogList", menuName = "Custom/DialogList", order = 145)]
public class DialogList : ScriptableObject
{
    public List<DialogGroup> dialogs;
}

[System.Serializable]
public struct DialogGroup
{
    public string dialogName;
    public List<DialogLine> dialogLines;
};

[System.Serializable]
public class DialogLine
{
    public string lineCode;
    public string scene;
    public string character;
    public string text;

    public AudioClip voice;
    public CameraPreset shot;
}
