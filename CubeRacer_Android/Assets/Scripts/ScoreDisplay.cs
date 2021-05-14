using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text text;
    public void EndDisplay(float score) {
        text.text = (score/10).ToString("0");
    }
}
