using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Manager : MonoBehaviour
{
    public CameraList cameraPresetsList;


    public static Camera_Manager instance;

    private void Awake()
    {
        instance = this;
    }


    public void ChangeCameraViewTo(string POVname)
    {

    }
}
