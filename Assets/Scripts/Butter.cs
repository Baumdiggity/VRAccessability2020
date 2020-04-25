using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butter : MonoBehaviour
{

    private Transform robotCarryPointToSnapTo;

    private void Start()
    {
        robotCarryPointToSnapTo = GameObject.FindGameObjectWithTag("ButterCarryPoint").gameObject.transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collided with something");
        if (collision.gameObject.tag == "Robot")
        {
            Debug.Log("collided with robot");
            //transform.SetParent(robotCarryPointToSnapTo);
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            //GetComponent<Collider>().enabled = false;

            transform.rotation = Quaternion.identity;
            transform.parent = robotCarryPointToSnapTo.transform;
            transform.position = robotCarryPointToSnapTo.transform.position;
            transform.localPosition = Vector3.zero;

        }
    }
}
