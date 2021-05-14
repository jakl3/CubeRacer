using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Text text;
    // Infinite Mode
    public void Infinite() {
        DATA.Infinite = true;
        Invoke("start", 0.1f);
    }

    // Survival Mode
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
    
    // General Buttons
    void start() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // Debug.Log(DATA.Infinite);
    }
    public void Credits() {
        Invoke("OpenCredits", 0.1f);
    }
    void OpenCredits() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    // 0 is easy, 1 is normal, 2 is hard
    // Difficulty Select
    void Start() {
        if (DATA.Difficulty == 0) {
            text.text = "CURRENT: EASY";
            Color c = new Color();
            ColorUtility.TryParseHtmlString("#FDFF36", out c);
            text.color = c;
        }
        else if (DATA.Difficulty == 1) {
            text.text = "CURRENT: MEDIUM";
            Color c = new Color();
            ColorUtility.TryParseHtmlString("#9EFF17", out c);
            text.color = c;
        }
        else if (DATA.Difficulty == 2) {
            text.text = "CURRENT: HARD";
            Color c = new Color();
            ColorUtility.TryParseHtmlString("#FF5147", out c);
            text.color = c;
        }
    }
    public void Easy() {
        DATA.Difficulty = 0;
        text.text = "CURRENT: EASY";
        Color c = new Color();
        ColorUtility.TryParseHtmlString("#FDFF36", out c);
        text.color = c;
    }
    public void Medium() {
        DATA.Difficulty = 1;
        text.text = "CURRENT: MEDIUM";
        Color c = new Color();
        ColorUtility.TryParseHtmlString("#9EFF17", out c);
        text.color = c;
    }
    public void Hard() {
        DATA.Difficulty = 2;
        text.text = "CURRENT: HARD";
        Color c = new Color();
        ColorUtility.TryParseHtmlString("#FF5147", out c);
        text.color = c;
    }
}
