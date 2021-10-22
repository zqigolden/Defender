using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    public Text scoreText;
    // Start is called before the first frame update
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = "SCORE: " + score;
    }
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
