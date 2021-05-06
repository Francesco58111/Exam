using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_Manager : MonoBehaviour
{
    public QuestList questList;


    public static Quest_Manager instance;

    private void Awake()
    {
        instance = this;
    }


    public void AskForQuest()
    {

    }

    public void LaunchQuest(string QuestName)
    {

    }

    bool IsAnyQuestAvailable()
    {

        return false;
    }


    public void CompleteObjective(string QuestName)
    {

    }
}
