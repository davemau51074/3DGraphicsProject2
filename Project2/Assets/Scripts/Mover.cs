using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Rigidbody rb2;
    public float speed;

    void Start()
    {
        rb2 = GetComponent<Rigidbody>();
        rb2.velocity = transform.forward * speed;
    }
	
}
