using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public int score = 0;
    // Start is called before the first frame update
    public static ScoreText instance;
    public Text scoreText;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int addScore()
    {
        score++;
        scoreText.text = "Score: " + score;
        return score;
    }
}
