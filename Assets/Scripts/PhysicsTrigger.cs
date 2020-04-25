using System;
using UnityEngine;
using UnityEngine.Events;


[Serializable]
public class TriggerEvent : UnityEvent<object> { }

[Serializable]
public class CollisionEvent : UnityEvent<object> { }

public class PhysicsTrigger : MonoBehaviour
{
    public string filterBy;
    public TriggerEvent TriggerEnter;
    public TriggerEvent TriggerStay;
    public TriggerEvent TriggerLeave;

    public CollisionEvent CollisionEnter;
    public CollisionEvent CollisionStay;
    public CollisionEvent CollisionExit;

    private void OnTriggerEnter(Collider other)
    {
        if( string.IsNullOrEmpty(filterBy) || other.tag == filterBy )
            TriggerEnter.Invoke(other);
    }

    private void OnTriggerStay(Collider other)
    {
        if (string.IsNullOrEmpty(filterBy) || other.tag == filterBy)
            TriggerStay.Invoke(other);
    }

    private void OnTriggerExit(Collider other)
    {
        if (string.IsNullOrEmpty(filterBy) || other.tag == filterBy)
            TriggerLeave.Invoke(other);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (string.IsNullOrEmpty(filterBy) || collision.gameObject.tag == filterBy)
            CollisionEnter.Invoke(collision);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (string.IsNullOrEmpty(filterBy) || collision.gameObject.tag == filterBy)
            CollisionStay.Invoke(collision);
    }

    private void OnCollisionExit(Collision collision)
    {
        if (string.IsNullOrEmpty(filterBy) || collision.gameObject.tag == filterBy)
            CollisionExit.Invoke(collision);
    }

}
