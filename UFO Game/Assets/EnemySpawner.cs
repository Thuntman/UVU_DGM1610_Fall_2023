using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
public GameObject [] enemy;
[SerializeField]
private float spawnRangeX = 17.0f;
[SerializeField]
private float spawnPosZ;
private float startDelay = 1f;
private float spawnInterval = 5f;
    // Start is called before the first frame update
    void Start()
    {
      InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);  
    }

    // Update is called once per frame
    void SpawnRandomEnemy()
    {
       Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0, spawnPosZ);
int enemyIndex = Random.Range(0, enemy.Length);
Instantiate(enemy[enemyIndex], spawnPos, enemy[enemyIndex].transform.rotation);    
    }
}
