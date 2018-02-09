using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_SkyBox : MonoBehaviour {

    public Material[] Skybox;
    int count;
    float nextchng = 0;
    public float chngInterval = 1000;

	// Use this for initialization
	void Start () {
        count = Skybox.Length;
        
    }

    private void Update()
    {
        int rand = Random.Range(0, count);
        Debug.Log(rand);
        if (Time.time > nextchng)
        {
            RenderSettings.skybox = Skybox[rand];
            nextchng = Time.time + chngInterval;
        }
    }

}
