using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMP : MonoBehaviour
{

    public GameObject[] waypoints;
    int currentWP = 0;

    public float speed = 10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Vector3.Dsitance(this.transform.position, waypoints[currentWP].transform.postion)< 3)
          //currentWP++; 
    }
}
