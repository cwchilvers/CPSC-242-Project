using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    private int _score = 0;

    public void UpdateScore()
    {
        _score = _score + 1;
        scoreText.text = _score.ToString();
    }
}
