using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Final : MonoBehaviour
{
    public TextMeshProUGUI info; // Assign this TextMeshProUGUI object in the Inspector
    public string mainMenuSceneName = "MainMenu"; // Set the main menu scene name in the Inspector

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            info.text = "Congratulations \n You Win";
            Invoke("ReturnToMainMenu", 2f); // Delay for 2 seconds before returning to the main menu
        }
    }

    private void ReturnToMainMenu()
    {
        SceneManager.LoadScene(mainMenuSceneName); // Load main menu scene
    }
}
