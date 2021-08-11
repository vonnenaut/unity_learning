using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float thrustForce = 1000f;
    [SerializeField] float turnRate = 110f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
        if( Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space) || Input.GetKey("w") )
        {
            rb.AddRelativeForce(Vector3.up * thrustForce * Time.deltaTime);
        }
    }

    void ProcessRotation()
    {
        if( Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d") )
        {
            rotateRocket(-turnRate);
        }
        else if ( Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a") ) 
        {
            rotateRocket(turnRate);
        }
    }

    private void rotateRocket(float turnRate)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * turnRate * Time.deltaTime);
        rb.freezeRotation = false;
    }
}
