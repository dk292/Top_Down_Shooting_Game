using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 10;

    public TMP_Text scoreText;
    public TMP_Text liveText;
    public TMP_Text gameOver;
    public GameObject pauseMenuUI;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        liveText.text = string.Format("Live: {0}", lives);

    }

    public void AddLives(int value)
    {
        lives += value;

        if (lives <= 0)
        {
            lives = 0;
            Time.timeScale = 0f;
            pauseMenuUI.SetActive(true);
            gameOver.gameObject.SetActive(true);
        }
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = string.Format("Score: {0}", score);
    }
}
