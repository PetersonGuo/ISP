using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Platformer.Mechanics;

public class EndScreen : MonoBehaviour
{
    public TextMeshProUGUI mainText, scoreText;

    void Start()
    {
        mainText.text = "You Win!";
        scoreText.text = "Score: " + Score.GetScore() + " / " + Score.GetMaxScore();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}