using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_Manager : MonoBehaviour
{
    public DialogList dialogList;


    public static Dialog_Manager instance;

    private void Awake()
    {
        instance = this;
    }


    public void LaunchDialog(string DialogName)
    {

    }


}
