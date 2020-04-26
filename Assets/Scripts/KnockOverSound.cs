using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockOverSound : MonoBehaviour
{
    bool fell = false;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.up.y < .6f && !fell)
        {
            fell = true;
            audioSource.PlayOneShot(audioSource.clip);
        }
    }
}
