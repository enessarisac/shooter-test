using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollSetter : MonoBehaviour
{
    Rigidbody [] rigidbodies;
    Collider [] colliders;
    Rigidbody rb;
    BoxCollider sc;
    private void Start() 
    {
        rigidbodies=GetComponentsInChildren<Rigidbody>();
        colliders=GetComponentsInChildren<Collider>();
        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic=true;
        }
        foreach (Collider collider in colliders)
        {
            collider.enabled=false;
        }
        rb=GetComponent<Rigidbody>();
        sc=GetComponent<BoxCollider>();
        rb.isKinematic=false;
        rb.constraints=RigidbodyConstraints.FreezeRotationX|RigidbodyConstraints.FreezeRotationZ;
        sc.enabled=true;
    }
    public void EnableRagdoll()
    {

        if(sc!=null)
        {
            Destroy(sc);
        }
        if(rb!=null)
        {
            Destroy(rb);
        }
        rigidbodies=GetComponentsInChildren<Rigidbody>();
        colliders=GetComponentsInChildren<Collider>();
        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic=false;
        }
        foreach (Collider collider in colliders)
        {
            collider.enabled=true;
        }
    }

}
