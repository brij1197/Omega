using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestructor : MonoBehaviour {

    public float TTL = 3;
	public float Destructor;

    void Start()
    {
        Destructor = Time.time + TTL;
    }


	void Update () {
		
        if(Time.time > Destructor)
        {
            Destroy(this.gameObject);
        }
      
	}
}
