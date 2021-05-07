using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using System.IO;
using System;
using UnityEditorInternal;

[CustomEditor(typeof(DialogGoupList))]
public class DialogEditor : Editor
{
    ReorderableList dialogListing;
    SerializedProperty dialogs;

    List<DialogGroup> dialogGroups;
    int NumberOfColumns = 7;


    private string csvPath = "Assets/CSV/Dialogs";


    private void OnEnable()
    {
        InterpreteCSV();
        dialogs = serializedObject.FindProperty("dialogs");
    }

    private void InterpreteCSV()
    {
        string[] csvInfo = LoadCSV().Split(',');


        int currentGroupIndex = -1;
        int currentInfo = 0;

        for (int i = NumberOfColumns+1; i < csvInfo.Length; i++)
        {

            if(csvInfo[i] == string.Empty)
            {
                continue;
            }
            else
            {
                
            }

            if (currentInfo == NumberOfColumns)
                currentInfo = 0;
        }
    }

    public override void OnInspectorGUI()
    {
        DrawUpdateButton();
        DrawUpdatedList();
    }

    private void DrawUpdatedList()
    {
        for (int i = 0; i < 10; i++)
        {
            EditorGUILayout.BeginVertical();

            EditorGUILayout.LabelField("Name of the group HERE");

            EditorGUILayout.EndVertical();
        }
    }

    //DO NOT VERIFY IF THE FOLDER EXIST!!! ------ THAT'S ACTUALLY A BAD THING NOT AN ORDER ^^
    private string LoadCSV()
    {
        TextAsset csv;

        if (AssetDatabase.IsValidFolder(csvPath))
        {
            string[] editorPaths = AssetDatabase.FindAssets("t:textasset", new string[] { csvPath });

            csv = AssetDatabase.LoadAssetAtPath(AssetDatabase.GUIDToAssetPath(editorPaths[0]), typeof(TextAsset)) as TextAsset;
        }
        else
        {
            csv = null;

            Debug.LogError("DialogList is missing");
        }

        Debug.Log(csv);
        return csv.ToString();
    }

    private void DrawUpdateButton()
    {
        if (GUILayout.Button("Update DialogList"))
        {
            string[] elements = LoadCSV().Split(',');

            for (int i = 0; i < elements.Length - 1; i++)
            {
                Debug.Log(elements[i] + "\n");
            }

        }

    }


}
