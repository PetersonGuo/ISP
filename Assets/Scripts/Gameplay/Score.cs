using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private static int maxScore, score;
    // Start is called before the first frame update
    void Start()
    {
        maxScore = GameObject.FindGameObjectsWithTag("Token").Length;
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
}
