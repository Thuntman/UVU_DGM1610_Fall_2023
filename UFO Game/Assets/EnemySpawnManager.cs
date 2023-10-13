using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
public GameObject[] ufoPrefabs;
public int ufoIndex;
[SerializeField]
private float spawnRangeX = 20.0f;
private float spawnPosZ = 20.0f;
private float startDelay = 3f;
private float spawnInterval = 5f;
void Start()
    {
      InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);  
    }
    // Update is called once per frame
    void SpawnRandomEnemy()
    {
       Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),2, spawnPosZ);
int ufoIndex = Random.Range(0,ufoPrefabs.Length);
     Instantiate(ufoPrefabs[ufoIndex],spawnPos, ufoPrefabs[ufoIndex].transform.rotation);
}   
    }