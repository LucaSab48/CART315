using UnityEngine;
using UnityEngine.UI;

public class Boundaries : MonoBehaviour
{
    public float score;
    public int lives = 3;
    public Image[] lifeImages; 

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void IncrementScore()
    {
        score += 1f;
        GameObject.Find("scoreOutput").GetComponent<Text>().text = score.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Circle")
        {
            Destroy(collision.gameObject);
            RemoveLife();
        }
    }

    private void RemoveLife()
    {
        if (lives > 0)
        {
            lives--; 
            lifeImages[lives].enabled = false;

            if (lives == 0)
            {
    
                Debug.Log("GAME OVER");
            }
        }
    }
}