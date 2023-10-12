using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
public GameObject [] item;
[SerializeField]
private float spawnRangeX = 17.0f;
private float spawnPosZ = 25.0f;
private float startDelay = 1f;
private float spawnInterval = 5f;
    // Start is called before the first frame update
    void Start()
    {
InvokeRepeating("SpawnRandomItem", startDelay, spawnInterval);
        
    }

    // Update is called once per frame
    void SpawnRandomItem()
    {
     Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0, spawnPosZ);
int itemIndex = Random.Range(0, item.Length);
Instantiate(item[itemIndex], spawnPos, item[itemIndex].transform.rotation);   
    }
}
