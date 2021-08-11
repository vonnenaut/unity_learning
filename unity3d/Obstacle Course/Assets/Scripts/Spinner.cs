using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xRotation = 0f;
    [SerializeField] float zRotation = 0f;
    [SerializeField] float yRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        yRotation = setSpin(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotation, yRotation, zRotation);
    }

    private float setSpin(string gObjName) 
    {
        if(gObjName == "Spinner1") {
            return 0.68f;
        } else if(gObjName == "Spinner2") {
            return 0.41f;
        } else if (gObjName == "Spinner3") {
            return 0.57f;
        } else {
            return 0.55f;
        }
    }
}