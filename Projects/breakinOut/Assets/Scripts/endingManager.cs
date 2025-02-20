using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenManager : MonoBehaviour
{
    public void TryAgain()
    {
        SceneManager.LoadScene("Breakout");
    }
    
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}

