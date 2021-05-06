using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;

[CustomEditor(typeof(DialogList))]
public class DialogEditor : Editor
{
    DialogList myTarget;

    private string csvPath = "Assets/CSV/Dialogs";

    private void OnEnable()
    {
        LoadCSV();
    }

    public override void OnInspectorGUI()
    {
        DrawUpdateButton();
    }

    private static void DrawUpdateButton()
    {
        if (GUILayout.Button("Update DialogList"))
        {

        }

    }

    string LoadCSV()
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

        //Debug.Log(csv);
        return csv.ToString();
    }
}
