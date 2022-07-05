using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float rangeX = 10.0f;
    public float rangeZ = 10.0f;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        var translateValueX = Vector3.right * (horizontalInput * speed * Time.deltaTime);
        var translateValueZ = Vector3.forward * (verticalInput * speed * Time.deltaTime);
        transform.Translate(translateValueX);
        if (transform.position.x < -rangeX || transform.position.x > rangeX)
        {
            transform.Translate(-translateValueX);
        }
        transform.Translate(translateValueZ);
        if (transform.position.z < 0 || transform.position.z > rangeZ)
        {
            transform.Translate(-translateValueZ);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
