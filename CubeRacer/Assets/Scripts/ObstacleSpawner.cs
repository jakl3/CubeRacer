using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public Transform ground;
    public Transform[] spawnPoints;
    public GameObject[] prefabs;
    public float distanceBetweenPoints;
    List<GameObject> spawnedObstacles = new List<GameObject>();

    void Start() {
        SpawnObstacle();
        Debug.Log("Spawned");
        distanceBetweenPoints = 40f;
    }

    void SpawnObstacle() {
        int randomSpawnIdx = Random.Range(0, spawnPoints.Length);
        for (int i = 0; i < spawnPoints.Length; i++) {
            int randomObjIdx = Random.Range(0, prefabs.Length);
            spawnedObstacles.Add(Instantiate(prefabs[randomObjIdx], spawnPoints[i].position, Quaternion.identity, spawnPoints[i]));
        }
    }

    public void move(float newPos) {
        foreach (GameObject item in spawnedObstacles) {
            Destroy(item);
        }
        transform.position = new Vector3(0, 0, newPos);
        SpawnObstacle();
    }
}
