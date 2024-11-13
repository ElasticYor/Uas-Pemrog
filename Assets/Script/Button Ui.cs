using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
   public void ToGame()
    {
        SceneManager.LoadScene("Gameplay 1");
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ToCredit()
    {
        SceneManager.LoadScene("Credit");
    }
    public void ToQuit()
    {
        Application.Quit();
    }
}
