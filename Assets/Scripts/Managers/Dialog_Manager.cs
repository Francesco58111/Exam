using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_Manager : MonoBehaviour
{
    public DialogGoupList groups;
    public DialogLineList lines;
    public DialogSystem dialogSystem;

    public static Dialog_Manager instance;


    private void Awake()
    {
        instance = this;
    }


    public void LaunchDialogSystem(string DialogName)
    {

    }

    public DialogLine GetDialogLineData(string LineCode)
    {
        if (lines.dialogLines.ContainsKey(LineCode))
            return lines.dialogLines[LineCode];
        else
            return new DialogLine();
    }

    public DialogGroup GetDialogGroupData(string groupName)
    {
        if (groups.dialogGroups.ContainsKey(groupName))
            return groups.dialogGroups[groupName];
        else
            return new DialogGroup();
    }
}
