using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Camera_Manager : MonoBehaviour
{
    public CameraList cameraPresetsList;

    public Dictionary<string, CameraPreset> presets;

    public CinemachineVirtualCamera[] availableCameras;
    private CinemachineVirtualCamera currentCam;

    public static Camera_Manager instance;

    private void Awake()
    {
        instance = this;

        presets = new Dictionary<string, CameraPreset>();
    }

    private void Update()
    {
        
    }


    public void GetCameraView(string POVname)
    {
        if (presets.ContainsKey(POVname))
            SetCameraView(presets[POVname]);
    }



    public void SetCameraView(CameraPreset preset)
    {
        CinemachineVirtualCamera cam = availableCameras[0];

        cam.transform.position = preset.camPos;
        cam.transform.rotation = preset.camRotation;
    }

    public void ChangeCamera(CinemachineVirtualCamera cam)
    {
        currentCam.Priority = 0;
        cam.Priority = 2;
        availableCameras[0] = currentCam;
        currentCam = cam;
    }
}
