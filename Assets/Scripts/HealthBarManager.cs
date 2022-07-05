using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarManager : MonoBehaviour
{
    public Slider healthBarPrefab;
    private Slider healthBar;
    private GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.FindGameObjectWithTag("Canvas");
        Vector3 position = new Vector3(gameObject.transform.position.x, canvas.transform.position.y,
            gameObject.transform.position.z);
        healthBar = Instantiate(healthBarPrefab, position, Quaternion.AngleAxis(-90, Vector3.right), canvas.transform);
        healthBar.value = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!healthBar.Equals(null))
        {
            Vector3 position = new Vector3(gameObject.transform.position.x, canvas.transform.position.y,
                gameObject.transform.position.z);
            healthBar.transform.position = position;
        }
    }

    public void DestroyHealthBar()
    {
        healthBar.transform.position = new Vector3(30, 0, 30);
        healthBar = null;
    }

    public void UpdateHealthBar(float health)
    {
        healthBar.value = health;
    }
}