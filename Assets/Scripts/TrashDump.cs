using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashDump : MonoBehaviour
{
    public GameObject[] trashObjects;
    public GameObject dustPoof;

    bool exploding = false;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Robot") && !exploding)
        {
            exploding = true;
            dustPoof.SetActive(true);
            for(int i =5; i>0; i--)
            {

               GameObject gO = Instantiate(trashObjects[Random.Range(0, trashObjects.Length - 1)], transform.position + Vector3.up, transform.rotation);
                if(gO.GetComponent<Rigidbody>() != null)
                {
                    gO.GetComponent<Rigidbody>().AddExplosionForce(.5f, this.transform.position, 1f);
                    Debug.Log("Exploded");
                }
            }
            this.gameObject.SetActive(false);
            
        }
    }
}
