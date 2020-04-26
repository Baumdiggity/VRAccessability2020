using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Hand))]
public class ForceRestart : MonoBehaviour
{
    public List<SteamVR_Action_Boolean> ForceReset = new List<SteamVR_Action_Boolean>()
    {
        SteamVR_Input.GetAction<SteamVR_Action_Boolean>("platformer", "Jump"),
        SteamVR_Input.GetAction<SteamVR_Action_Boolean>("Pinch", "GrabPinch")
    };
    public float SecondsToHoldForReset = 10f;

    private Hand hand;
    private Interactable interactable;
    private SteamVR_Input_Sources source;
    // Start is called before the first frame update
    void Start()
    {
        interactable = this.gameObject.AddComponent<Interactable>();
        hand = this.gameObject.GetComponent<Hand>();
        interactable.OnAttachedToHand(hand);
    }

    private float t;
    // Update is called once per frame
    void Update()
    {
        source = interactable.attachedToHand.handType;
        bool isHold = true;
        foreach( var v in ForceReset )
        {
            if (!v[source].state)
            {
                isHold = false;
                break;
            }
        }

        if (isHold)
        {
            t += Time.deltaTime;
            if (SecondsToHoldForReset < t)
            {
                SteamVR_Fade.Start(Color.clear, 0);
                SteamVR_Fade.Start(Color.black, 0.3f);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else
        {
            t = 0;
        }
    }
}
