using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    // Start is called before the first frame updat

    public void End() {
        Invoke("RestartGame", 0.1f);
    }
    void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Quit() {
        Invoke("QuitGame", 0.1f);
    }
    void QuitGame() {
        Application.Quit();
    }
}
