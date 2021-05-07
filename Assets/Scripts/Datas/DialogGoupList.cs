using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SC_DialogGroupList", menuName = "Custom/DialogGroups", order = 145)]
public class DialogGoupList : ScriptableObject
{
    public Dictionary<string, DialogGroup> dialogGroups;
}

public struct DialogGroup
{
    public List<string> lineCodes;
    public int priority;
    //music state
};
