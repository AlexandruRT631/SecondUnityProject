using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float range = 10.0f;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        var translateValue = Vector3.right * (horizontalInput * speed * Time.deltaTime);
        transform.Translate(translateValue);
        if (transform.position.x < -range || transform.position.x > range)
        {
            transform.Translate(-translateValue);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
