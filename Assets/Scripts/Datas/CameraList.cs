using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SC_CameraPresets_", menuName = "Custom/CameraPresets", order = 155)]
public class CameraList : ScriptableObject
{
    public Dictionary<string, CameraPreset> cameraPresets;
}

[System.Serializable]
public struct CameraPreset
{
    public Vector3 position;
    public GameObject lookAt;
}

[System.Serializable]
public struct BrickPreset
{
    public string tag;
    public int armorValue;
    public int scoreValue;
}
