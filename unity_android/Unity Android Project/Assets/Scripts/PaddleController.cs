using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TouchMove()
    {
        if(Input.GetMouseButton(0))
        {
            
        }
    }
}
