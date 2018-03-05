using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotatar : MonoBehaviour {

    private Rigidbody rb3;
    public float tumble;
    // Use this for initialization
    void Start () {

        rb3 = GetComponent<Rigidbody>();

        rb3.angularVelocity = Random.insideUnitSphere * tumble;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
