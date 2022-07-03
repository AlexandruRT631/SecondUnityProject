using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOOB : MonoBehaviour
{
    public float topBound = 30.0f;
    public float lowerBound = -10.0f;
    public float sideBound = 30.0f;
    
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.z > topBound || transform.position.z < lowerBound || transform.position.x > sideBound || transform.position.x < -sideBound)
        {
            Destroy(gameObject);
        }
    }
}
