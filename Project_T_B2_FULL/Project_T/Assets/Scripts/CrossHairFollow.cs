using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrossHairFollow : MonoBehaviour {

    Image crshr;
    public GameObject FollowTarget;
    public float diff = 1;

	// Use this for initialization
	void Start () {
        crshr = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {

        crshr.rectTransform.position = FollowTarget.transform.position * 500;

    }
}
