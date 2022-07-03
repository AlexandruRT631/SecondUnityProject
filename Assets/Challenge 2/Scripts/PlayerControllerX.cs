using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastTime = 0.0f;
    public float spawnDelay = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (lastTime + spawnDelay < Time.time)
            {
                lastTime = Time.time;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
    }
}
