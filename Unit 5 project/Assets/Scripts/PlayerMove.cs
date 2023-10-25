using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float horizontalInput;
 public float speed;
 public float xRange;

    // Update is called once per frame
    void Update()
    {
horizontalInput = Input.GetAxis("Horizontal");
	transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
if(transform.position.x < -xRange )
{
transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
}
if(transform.position.x > xRange )
{
transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
}      
    }
}
