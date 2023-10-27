using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
 private ScoreManager scoreManager; // A variable to hold the reference to the scoremanager
    public int scoreToGive;

private AudioSource explosionAudio;
    public AudioClip explosionSound;


    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Reference scoremanager
explosionAudio = GetComponent<AudioSource>();
        
    }

    void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive); // Increase Score 
        Destroy(other.gameObject); //Destroy the other game object it hits
        Destroy(gameObject); // Destroy this game object 
        explosionAudio.PlayOneShot(explosionSound, 1f);
    }
}