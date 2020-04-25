using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwapCamera();
        }
    }

    public void SwapCamera()
    {
        currentIndx++;
        if (currentIndx > listOfCameras.Count -1)
        {
            currentIndx = 0;
        }

        //teleport player here
        Teleport.instance.TeleportPlayerToPoint(listOfCameras[currentIndx].gameObject.transform);
    }
}
