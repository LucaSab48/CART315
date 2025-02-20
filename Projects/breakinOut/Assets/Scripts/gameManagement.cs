using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManagement : MonoBehaviour
{
    public int points = 0;
    public int lives = 3;

    public static gameManagement S;
    
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    void Awake()
    {
        S = this;
    }

    public void loseLife()
    {
        lives -= 1;
        Debug.Log(lives);
        
        UpdateLifeUI();
        
        if (lives <= 0) EndScreen();
    }
    
    public void UpdateLifeUI()
    {
        if (lives == 2)
        {
            heart3.SetActive(false);  
        }
        else if (lives == 1)
        {
            heart2.SetActive(false); 
        }
        else if (lives <= 0)
        {
            heart1.SetActive(false); 
        }
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
