using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotSounds : MonoBehaviour
{
    public AudioClip[] listOfClips;
    public AudioSource audio;
    public AudioClip jumpClip;
    public AudioClip butterClip;
    public AudioSource movingAudSource;
    private float randTimeInterval = 5;
    private int randIndx;

    private void Start()
    {
            
    }

    private void Update()
    {
        randTimeInterval -= Time.deltaTime;
        if (randTimeInterval <= 0)
        {
            //play a random clip of robo voice every x seconds
            randIndx = Random.Range(0, listOfClips.Length - 1);
            audio.clip = listOfClips[randIndx];
            audio.Play();
            randTimeInterval = Random.Range(5, 30);
        }

        //detect jump play jump sfx

        //detect movement play moving sound

        //detect butter and play butter noise
    }
}
