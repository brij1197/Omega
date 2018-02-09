using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_Script : MonoBehaviour {

    public float Speed,MaxSpeed;
    public GameObject Explosion;
    public float inc;

	void Start () {
		
	}

	void Update () {

        transform.position += transform.forward * Speed * Time.deltaTime;

	}

    

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision at " + transform.position);
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(Explosion, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }
}
