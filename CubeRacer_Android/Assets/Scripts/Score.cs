using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text text;
    Color original;
    public float score;
    float lostPoints;
    void Start() {
        original = text.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (lostPoints > player.position.z) lostPoints = player.position.z;
        score = player.position.z - lostPoints;
        text.text = (score/10).ToString("0");
    }

    public void collide() {
        StartCoroutine(collision());
    }

    IEnumerator collision() {
        text.color = Color.red;
        lostPoints += 100;
        yield return new WaitForSeconds(0.4f);
        text.color = original;
    }
}
