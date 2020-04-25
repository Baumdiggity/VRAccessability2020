using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class CameraSwitcher : MonoBehaviour
{
    public List<GameObject> listOfCameras;
    public int currentIndx;
    public SteamVR_Input_Sources inputSource = SteamVR_Input_Sources.Any;//which controller

    // Start is called before the first frame update
    void Start()
    {
        listOfCameras = new List<GameObject>(GameObject.FindGameObjectsWithTag("TeleportCamera"));
    }

    public void SwapCamera()
    {
        currentIndx++;
        if (currentIndx > listOfCameras.Count)
        {
            currentIndx = 0;
        }
    }
}
