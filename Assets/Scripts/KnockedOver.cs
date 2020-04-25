using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockedOver : MonoBehaviour
{
    public GameObject[] trashObjects;
    public GameObject dustPoof;
    bool exploding = false;

    // Update is called once per frame
    void Update()
    {
        if (transform.up.y < .6f && !exploding)
        {
            exploding = true;
            dustPoof.SetActive(true);
            for (int i = Random.Range(1,5); i > 0; i--)
            {

                GameObject gO = Instantiate(trashObjects[Random.Range(0, trashObjects.Length - 1)], transform.position + Vector3.up, transform.rotation);
                if (gO.GetComponent<Rigidbody>() != null)
                {
                    gO.GetComponent<Rigidbody>().AddExplosionForce(0.25f, this.transform.position, 1f);
                    Debug.Log("Exploded");
                }
            }
        }
    }
}
