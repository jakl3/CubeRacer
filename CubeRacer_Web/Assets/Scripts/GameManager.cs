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
    public GameObject difficulty;
    public PlayerController player;
    public GameObject ground;

    bool gameEnded = false;

    void Start() {
        Debug.Log(DATA.Difficulty);
        if (DATA.Infinite == true) {
            lives.SetActive(false);
        }
        if (DATA.Difficulty == 0) {
            player.Easy();
            ground.transform.localScale = new Vector3(18,1,800);
        }
        if (DATA.Difficulty == 1) {
            player.Medium();
            ground.transform.localScale = new Vector3(15,1,800);
        }
        if (DATA.Difficulty == 2) {
            player.Hard();
            ground.transform.localScale = new Vector3(15,1,800);
        }
    }

    public void GameOver() {
        gameScore.SetActive(false);
        lives.SetActive(false);
        difficulty.SetActive(false);
        completeLevelUI.SetActive(true);
        if (gameEnded == false) {
            gameEnded = true;
            // Debug.Log("End game");
            scoreDisplay.EndDisplay(score.score);
        }
        
    }
}
