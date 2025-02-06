using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManagement : MonoBehaviour
{
    public int points = 0;
    public int lives = 3;

    public static gameManagement S;

    void Awake()
    {
        S = this;
    }

    public void loseLife()
    {
        lives -= 1;
        Debug.Log(lives);
        
        if (lives <= 0) EndScreen();
    }

    public void EndScreen()
    {
        SceneManager.LoadScene("EndScreen");
    }

    public void AddPoint(int numPoints)
    {
        points += numPoints;
    }
}
