using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
private ScoreManager scoreManager;
public int scoreToGive;
void Start()
{
scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
}
    
    void OnTriggerEnter(Collider other)
{

Destroy(gameObject);
Destroy(other.gameObject);
scoreManager.IncreaseScore(scoreToGive);
}
}
