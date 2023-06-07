using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Platformer.Mechanics;


public class EndScreen : MonoBehaviour
{
    public TextMeshProUGUI mainText, scoreText;
    public AudioSource win, lose;

    void Start()
    {
        mainText.text = Score.GetMainText();
        if (mainText.text == "You Win!")
        {
            win.Play();
            lose.Stop();
        }
        else
        {
            lose.Play();
            win.Stop();
        }
        scoreText.text = "Pages Collected: " + Score.GetScore() + " / " + Score.GetMaxScore();
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