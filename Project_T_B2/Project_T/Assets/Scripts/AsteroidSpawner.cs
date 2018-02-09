using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {

    public GameObject[] Asteroid;
    public float interval;
    public float minTime = 0.5f, maxTime=2.5f;
    public float Speed = 10, MaxSpeed = 20,inc = 0.01f;
    public bool isPlayable = false;
    // Use this for initialization
	void Start () {
        interval = Time.time + Random.Range(minTime, maxTime);
    }

    private void FixedUpdate()
    {
        if (Speed < MaxSpeed)
            Speed += inc;
        if (maxTime > 1)
            maxTime -= 0.01f;
    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.FindGameObjectWithTag("Player") && isPlayable)
        {
            int val = Random.Range(0, 1);

            if (Time.time > interval)
            {
                //Instantiate here
                Asteroid[val].GetComponent<Asteroid_Script>().Speed = Speed;
                Debug.Log("Asteroid at " + transform.position);
                Instantiate(Asteroid[val], transform.position, Asteroid[val].transform.rotation);
                interval = Time.time + Random.Range(minTime, maxTime);
            }
        }
    }

    public void setPlayability(bool val)
    {
        isPlayable = val;
    }
}
