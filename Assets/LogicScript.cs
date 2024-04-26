using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject GameOverScreen;


    [ContextMenu("Increase Score")]
    public void ScoreCal(int addScore)
    {
        score += addScore;
        scoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver() {
        GameOverScreen.SetActive(true);
    }
}
