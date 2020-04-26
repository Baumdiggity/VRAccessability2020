using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkTrigger : MonoBehaviour
{
    public GameObject particleObject;
    bool isON = false;
    bool delay = false;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Robot"))
        {
            if (!delay)
            {
                isON = !isON;
                particleObject.SetActive(isON);
                if (isON)
                {
                    audioSource.Play();
                }
                else
                {
                    audioSource.Stop();
                }
                StartCoroutine("SinkOn");
            }
        }
    }

    IEnumerator SinkOn()
    {
        delay = true;
        yield return new WaitForSeconds(1f);
        delay = false;
    }
}
