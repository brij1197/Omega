using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Asteroid_Script : MonoBehaviour {

    public float Speed,MaxSpeed;
    public GameObject Explosion;
    public GameObject GameMaster;

    public float inc;

	void Start () {
        
	}

	void Update () {

        transform.position += transform.forward * Speed * Time.deltaTime;
        GameMaster = GameObject.FindGameObjectWithTag("GameMaster");
	}

    

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision at " + transform.position);
        if (collision.gameObject.tag == "Player")
        {

            int score = (int)GameMaster.GetComponent<ScoreCounter>().Score;
            int highscore = PlayerPrefs.GetInt("HighScore");
            Debug.Log(highscore);
            if (score > highscore)
            {
                PlayerPrefs.SetInt("HighScore", score);
                PlayerPrefs.Save();
            }

            Instantiate(Explosion, transform.position, Quaternion.identity);
           
            Destroy(collision.gameObject);
           
        }
    }

}
