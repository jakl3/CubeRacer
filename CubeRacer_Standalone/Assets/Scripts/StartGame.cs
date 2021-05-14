using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void Infinite() {
        DATA.Infinite = true;
        Invoke("start", 0.1f);
    }
    public void Survival10() {
        DATA.Infinite = false;
        DATA.Lives = 10;
        Invoke("start", 0.1f);
    }
    public void Survival20() {
        DATA.Infinite = false;
        DATA.Lives = 20;
        Invoke("start", 0.1f);
    }
    public void Survival30() {
        DATA.Infinite = false;
        DATA.Lives = 30;
        Invoke("start", 0.1f);
    }
    void start() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log(DATA.Infinite);
    }
    

    public void Credits() {
        Invoke("OpenCredits", 0.1f);
    }
    void OpenCredits() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void Quit() {
        Invoke("QuitGame", 0.1f);
    }
    void QuitGame() {
        Application.Quit();
    }
}
