using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
public float speed = 50.0f;

private AudioSource ufoAudio;
    public AudioClip ufoMove;

void Start()
	{
		ufoAudio = GetComponent<AudioSource>();
	}
    // Update is called once per frame
    void Update()
    {
    transform.Translate(Vector3.forward * Time.deltaTime * speed);   
	ufoAudio.PlayOneShot(ufoMove, 1f);
    }
}
