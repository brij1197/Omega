using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseShoot : MonoBehaviour {


    public GameObject Laserorigin, LB;

    void Update()
    {

        Shoot();

    }

    void Shoot()
    {
        if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) && GetComponent<Key_move>().isPlayable)
        {
            Instantiate(LB, Laserorigin.transform.position, LB.transform.rotation);
        }

    }
}
