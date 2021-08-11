using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    Color color;

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.name == "Player" && gameObject.tag != "Hit") {
            color = GetComponent<MeshRenderer>().material.color;
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    private void OnCollisionExit(Collision other) {
        if(other.gameObject.name == "Player") {
            GetComponent<MeshRenderer>().material.color = color;
            gameObject.tag = "Hit";
        }
    }
}