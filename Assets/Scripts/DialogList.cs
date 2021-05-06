using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SC_DialogList", menuName = "Custom/DialogList", order = 145)]
public class DialogList : ScriptableObject
{
    public Dialog[] dialogs;
}

[System.Serializable]
public struct Dialog
{
    public string dialogName;
    public string[] dialogLines;
};
