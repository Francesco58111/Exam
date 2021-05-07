using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogSystem : MonoBehaviour
{
    public bool IsDialogPlaying = false;
    public DialogGroup currentPlayedDialog;
    private int currentDialogLineIndex = 0;



    public void StartDialog(DialogGroup dialogToPlay)
    {
        IsDialogPlaying = true;
        DisplayLine(GetLineData());
    }

    public void StopAllDialogs()
    {
        //Clean Dialog Display

        //Set Player Camera Back to Gameplay

        IsDialogPlaying = false;
    }

    private void DisplayLine(DialogLine line)
    {
        //Change DialogBox Background

        //Display character

        //Display Text
    }

    private void NextLine()
    {
        currentDialogLineIndex++;
        DisplayLine(GetLineData());
    }

    private DialogLine GetLineData()
    {
        return Dialog_Manager.instance.GetDialogLineData(currentPlayedDialog.lineCodes[currentDialogLineIndex]);
    }
}
