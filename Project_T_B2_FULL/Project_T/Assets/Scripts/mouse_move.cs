using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mouse_move : MonoBehaviour {

    public float Sensitivity = 1;
    Vector3 refPos, MousePos, offset;
    // Use this for initialization
    void Start () {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
        refPos = Camera.main.ScreenToViewportPoint(new Vector3(Screen.width / 2, Screen.height / 2, transform.position.z));
       
    }
	
	// Update is called once per frame
	void Update () {
        float mouseX = Mathf.Clamp(Input.mousePosition.x, 0, Screen.width - 1);
        float mouseY = Mathf.Clamp(Input.mousePosition.y, Screen.height / 2.5f, Screen.height-1);
        MousePos = Camera.main.ScreenToViewportPoint(new Vector3(mouseX, mouseY, transform.position.z));
        offset = MousePos - refPos;
        Debug.Log(transform.position = offset*Sensitivity);

    }

}
