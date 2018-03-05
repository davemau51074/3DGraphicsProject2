using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TrackSpawn : MonoBehaviour
{
    public GameObject[] m_track;
    public GameObject cube;
    public GameObject currentTrack;
    public GameObject lastTrack;
    public GameObject nextTrack;

  //  int milestone = 10;
    Vector3 m_lastPos;
    
    // Use this for initialization
    void Start()
    {
     
        m_lastPos = new Vector3(0, -1,0);
        
        /*lastTrack = *///Instantiate(m_track[0], m_lastPos, Quaternion.Euler(-90, 0, -90));
        //lastTrack.transform.Rotate(0, 0, -90);

        Debug.Log("Spawning: " + currentTrack.name);
        //currentTrack = Instantiate(currentTrack,
        //    transform.position,
        //    Quaternion.Euler(-90, 0, -90));

        for (int i = 0; i < 4; i++)
        {
            spawn();
        }


    }

    // Update is called once per frame
    void Update()
    {
       // if ()
        //{
            spawn();
        //}
    }

    public void spawn()
    {

        //int i = Random.Range(2, m_track.Length + 100) ;

        Vector3 newPos = m_lastPos;
        newPos.z -= lastTrack.GetComponent<BoxCollider>().bounds.size.z;
        lastTrack = Instantiate(currentTrack,
            new Vector3(transform.position.x, 3, transform.position.z +newPos.z), 
            Quaternion.Euler(-90, 0, -90));

        Debug.Log("spawn");

        m_lastPos = newPos;
    }

}






