using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    Color original;
    int lives;
    float prev;
    public Text text;
    void Start() {
        original = text.color;
        lives = DATA.Lives == 0 ? 10 : DATA.Lives;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = lives + " LIVES";
    }

    IEnumerator colorChange() {
        text.color = Color.red;
        yield return new WaitForSeconds(0.4f);
        text.color = original;
    }

    public void DeductLife() {
        if (Time.time > prev + 0.2f) {
            prev = Time.time;
            lives--;
            StartCoroutine(colorChange());
        }
        
    }

    public int getLives() {
        return lives;
    }
}
