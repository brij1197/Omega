using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

    public float Score = 0,highScore = 0;
    public Canvas GameUI;
    public Text Scoretext,HighscoreText;
    public Key_move Player;

    void Start () {
        if (PlayerPrefs.HasKey("HighScore"))
            highScore = PlayerPrefs.GetInt("HighScore");
        else
        {
            highScore = 0;
            PlayerPrefs.SetInt("HighScore", 0);
        }
	}
	
	void FixedUpdate () {
		
        if(Player && Player.isPlayable)
        {
            GameUI.enabled = true;
            Score += 0.1f;
            Scoretext.text = "Score : " + ((int)Score).ToString();
            HighscoreText.text = "Highscore : " + highScore.ToString();
        }
        else
        {
            GameUI.enabled = false;
        }

	}

    void addToScore(int val)
    {
        Score += val;
    }
}
