using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUI : MonoBehaviour
{

    public AsteroidSpawner[] AS;
    public Key_move Spaceship;
    public Canvas menuCanvas;

    public void Play()
    {

        foreach (AsteroidSpawner a in AS)
        {
            a.setPlayability(true);
        }

        Spaceship.setPlayability(true);
        menuCanvas.enabled = false;

    }

    public void Settings()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }
}
