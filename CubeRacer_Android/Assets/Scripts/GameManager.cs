using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Score score;
    public ScoreDisplay scoreDisplay;
    public GameObject completeLevelUI;
    public GameObject gameScore;
    public GameObject lives;
    bool gameEnded = false;

    void Start() {
        if (DATA.Infinite == true) {
            lives.SetActive(false);
        }
    }

    public void GameOver() {
        gameScore.SetActive(false);
        lives.SetActive(false);
        completeLevelUI.SetActive(true);
        if (gameEnded == false) {
            gameEnded = true;
            Debug.Log("End game");
            scoreDisplay.EndDisplay(score.score);
        }
        
    }
}
