using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : MonoBehaviour {


    public GameObject Explosion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position += transform.up * 0.5f;

	}

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Instantiate(Explosion, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
