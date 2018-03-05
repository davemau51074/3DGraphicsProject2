using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin ,yMax,  zMin, zMax;

}
public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    private Rigidbody rb;
    private AudioSource audioSource;
    public Boundary boundary;
   public float tilt;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
           // GameObject clone = 
          //  Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
         //   audioSource.Play();
        }
    }
    

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal * rb.rotation.y, 0.0f, moveVertical );
        rb.velocity = movement * speed;
        

      //  rb.position = new Vector3(
      //      Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax ),
       //     0.0f,
           //  Mathf.Clamp(rb.position.y, boundary.yMin, boundary.yMax);

        rb.rotation = Quaternion.Euler(0.0f, 180.0f, rb.position.z * -tilt);
    }
	
}
