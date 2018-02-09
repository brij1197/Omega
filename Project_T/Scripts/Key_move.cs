using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_move : MonoBehaviour {
    public float moveSpeed = 2f;
    public float h, v;
    public bool isPlayable = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (isPlayable == true) {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");

            transform.position += transform.right * moveSpeed * h;
            transform.position += transform.forward * moveSpeed * v;

            Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
            pos.x = Mathf.Clamp(pos.x, 0.1f, 0.9f);
            pos.y = Mathf.Clamp(pos.y, 0.1f, 0.9f);
            transform.position = Camera.main.ViewportToWorldPoint(pos);
        }
    }

   public void setPlayability(bool val)
    {
        isPlayable = val;
    }
}
