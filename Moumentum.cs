using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moumentum : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2D.AddForce(transform.right * speed);
    }
}
