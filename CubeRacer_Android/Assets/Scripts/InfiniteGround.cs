using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteGround : MonoBehaviour
{
    public Transform player;
    public ObstacleSpawner obstacleSpawner1;
    public ObstacleSpawner obstacleSpawner2;
    // Start is called before the first frame update
    public float groundLength = 800f;
    bool obsOne;

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(transform.position.z + " " + player.transform.position.z);
        if (player.transform.position.z > transform.position.z) {
            //Debug.Log("shift: " + transform.position.z);
            transform.position = new Vector3(0, 0, transform.position.z + obstacleSpawner1.distanceBetweenPoints * obstacleSpawner1.spawnPoints.Length);
            if (obsOne) {
                //obstacleSpawner1.move(transform.position.z - groundLength/2 + 5);
                obstacleSpawner2.move(transform.position.z - groundLength/2 + 5 + obstacleSpawner1.distanceBetweenPoints * obstacleSpawner1.spawnPoints.Length);
            }
            else {
                //obstacleSpawner2.move(transform.position.z - groundLength/2 + 5);
                obstacleSpawner1.move(transform.position.z - groundLength/2 + 5 + obstacleSpawner1.distanceBetweenPoints * obstacleSpawner1.spawnPoints.Length);
            }
            obsOne = !obsOne;
        }
    }
}
