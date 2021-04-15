using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Score = 0;
    public Text ScoreText = null;
    public Text CountDownText = null;

    public GameObject ScoreObject = null;
    public GameObject StartScreen = null;


    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateScore()
    {
        Score++;
        ScoreText.text = Score.ToString();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        StartGame();
    }
    public void StartGame()
    {   
            Time.timeScale = 1.0f;
            ScoreObject.SetActive(true);
            StartScreen.SetActive(false);
    }

}
