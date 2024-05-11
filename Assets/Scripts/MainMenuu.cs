using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuu : MonoBehaviour
{
    
    public void PlayGameE()
    {
        SceneManager.LoadScene(1);
        GameManager.difficultE = 10;
        GameManager.coindiff = 15;
    }
    public void PlayGamem()
    {
        SceneManager.LoadScene(1);
        GameManager.difficultE = 20;
        GameManager.coindiff = 20;
    }
    public void PlayGameH()
    {
        SceneManager.LoadScene(1);
        GameManager.difficultE = 40;
        GameManager.coindiff = 25;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
