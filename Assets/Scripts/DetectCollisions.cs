using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public int health = 1;
    private float maxHealth = 1;
    private GameObject gameStats;

    // Start is called before the first frame update
    void Start()
    {
        gameStats = GameObject.Find("Player");
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.name.Equals("Player"))
        {
            health--;
            if (health <= 0)
            {
                if (gameObject.name.Contains("Dog") && other.name.Contains("Food"))
                {
                    gameObject.GetComponent<HealthBarManager>().DestroyHealthBar();
                    gameStats.GetComponent<GameStats>().IncreaseScore();
                }

                Destroy(gameObject);
                // Destroy(other.gameObject);
            }
            else
            {
                if (gameObject.name.Contains("Dog"))
                {
                    gameObject.GetComponent<HealthBarManager>().UpdateHealthBar(1.0f - health / maxHealth);
                }
            }
        }
        else if (gameObject.name.Contains("Dog"))
        {
            gameStats.GetComponent<GameStats>().DecreaseLives();
        }
    }
}