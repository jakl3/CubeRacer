using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 shift;

    void Awake() {
        shift = new Vector3(0, 1.3f, -7);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + shift;
    }
}
