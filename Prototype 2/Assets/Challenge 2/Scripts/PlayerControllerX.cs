using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float speed = 15.0f;

    
    public float horizontalInput;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -25.0f)
        {
            transform.position = new Vector3(-25.0f, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 21.0f)
        {
            transform.position = new Vector3(21.0f, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.back * horizontalInput * Time.deltaTime * speed);
       
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
