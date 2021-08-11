using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer rndr;
    Rigidbody rbody;
    [SerializeField] float timeToWait = 3f;

    void Start()
    {
        rndr = GetComponent<MeshRenderer>();
        rbody = GetComponent<Rigidbody>();

        rndr.enabled = false;
        rbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= timeToWait) {
            rndr.enabled = true;
            rbody.useGravity = true;
        }
    }
}
