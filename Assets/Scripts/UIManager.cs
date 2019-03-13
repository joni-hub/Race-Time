using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    int score;
    bool gameOver;
    public Button[] buttons;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gameOver = false;
        InvokeRepeating("scoreUpdate", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    // increment the score
    void scoreUpdate()
    {
        if(!gameOver)
        {
            score += 1;
        }
    }

    public void GameOver()
    {
        gameOver = true;
        foreach(Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }

    public void Play() => SceneManager.LoadScene("Level1");

    public void Pause()
    {
        if (Time.timeScale == 1.0f)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

    public void Replay() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    public void Menu() => SceneManager.LoadScene("Menu");

    public void Quit() => Application.Quit();
}
