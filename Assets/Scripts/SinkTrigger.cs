using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkTrigger : MonoBehaviour
{
    public GameObject particleObject;
    bool isON = false;
    bool delay = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Robot"))
        {
            if (!delay)
            {
                isON = !isON;
                particleObject.SetActive(isON);
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
