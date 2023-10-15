using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintPercent : MonoBehaviour
{
    void Start()
    {
        const int MaxScore = 100;

        int score = 56;

        float percent = (float)score / MaxScore;

        Debug.Log(percent);

        Debug.Log(percent * 100 + "%");
    }
}
