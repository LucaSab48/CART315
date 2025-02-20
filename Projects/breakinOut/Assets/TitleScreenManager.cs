using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenManager : MonoBehaviour
{
    public GameObject titleScreenPanel;

    void Start()
    {

        if (titleScreenPanel != null)
        {
            titleScreenPanel.SetActive(true);
        }


        Time.timeScale = 0f;
    }

    public void StartGame()
    {

        if (titleScreenPanel != null)
        {
            titleScreenPanel.SetActive(false);
        }


        Time.timeScale = 1f;
    }

    public void QuitGame()
    {

        Application.Quit();


        Debug.Log("Game Quit");
    }
}