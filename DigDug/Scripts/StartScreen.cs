using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(19);
    }
   
    public void GoToGameScene()
    {
        SceneManager.LoadScene(20);
    }
    
    public void EndGame()
    {
        SceneManager.LoadScene(21);
    }
    public void QuitGame()
    {
       
        Application.Quit();
    }
}
