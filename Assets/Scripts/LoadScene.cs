using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string SceneToLoad;

    /// <summary>
    /// Load the scene when the robot enters the triggers
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if( other.tag == "Robot")
            //SceneManager.LoadScene(SceneToLoad);
            Valve.VR.SteamVR_LoadLevel.Begin(SceneToLoad);
    }
}
