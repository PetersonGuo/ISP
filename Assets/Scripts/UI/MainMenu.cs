using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void PlayGame() {
        // Load the next scene in the build index
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        // Quit the game
        Application.Quit();
    }
}