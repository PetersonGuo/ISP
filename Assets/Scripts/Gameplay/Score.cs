using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private static int maxScore = 100, score;
    private static string mainText;
    // Start is called before the first frame update
    void Start()
    {
        mainText = "You Win!";
    }

    public static void Increment()
    {
        score++;
    }

    public static int GetScore()
    {
        return score;
    }

    public static int GetMaxScore()
    {
        return maxScore;
    }

    public static void SetMainText(string text)
    {
        mainText = text;
    }

    public static string GetMainText()
    {
        return mainText;
    }
}
