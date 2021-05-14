using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyShow : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        if (DATA.Difficulty == 0) {
            text.text = "EASY";
            Color c = new Color();
            ColorUtility.TryParseHtmlString("#FDFF36", out c);
            text.color = c;
        }
        else if (DATA.Difficulty == 1) {
            text.text = "MEDIUM";
            Color c = new Color();
            ColorUtility.TryParseHtmlString("#9EFF17", out c);
            text.color = c;
        }
        else if (DATA.Difficulty == 2) {
            text.text = "HARD";
            Color c = new Color();
            ColorUtility.TryParseHtmlString("#FF5147", out c);
            text.color = c;
        }
    }
}
