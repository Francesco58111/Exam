using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

[CreateAssetMenu(fileName = "SC_CameraPresets", menuName = "Custom/CameraPresets", order = 155)]
public class CameraList : ScriptableObject
{
    //YOU SHOULD USE A DICTIONARY BUT I DON'T HAVE ODIN neither the time
    //public Dictionary<string, CameraPreset> cameraPresets;

    public string[] presetsName;
    public CameraPreset[] presets;
}

[System.Serializable]
public struct CameraPreset
{
    public Vector3 camPos;
    public Quaternion camRotation;

    public TimelineAsset timeline;
}
