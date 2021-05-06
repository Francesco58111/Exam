using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SC_QuestRepertory", menuName = "Custom/QuestRepertory", order = 135)]
public class QuestList : ScriptableObject
{
    public Quest[] quests;
}

 [System.Serializable]
public class Quest
{
    private bool isUnlocked;
    private int currentObjective;
    private Objective[] objectives;
}

[System.Serializable]
public struct Objective
{
    private bool isGiven;
    private bool isCompleted;

    public DialogGroup expositionDialog;
    public DialogGroup[] recallDialogs;
}
