using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBounds = 30.0f;
    private float lowerBounds = -10.0f;
    private float leftBounds = -23.0f;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < leftBounds)
        {
            Destroy(gameObject);
        }
    }
}
