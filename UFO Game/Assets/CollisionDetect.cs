using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
{
Destroy(gameObject);
Destroy(other.gameObject);
}
}