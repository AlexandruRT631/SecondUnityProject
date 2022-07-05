using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour
{
    private int lives = 3;
    private int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore()
    {
        score++;
        Debug.Log("Score: " + score);
    }
    
    public void DecreaseLives()
    {
        if (lives > 0)
        {
            lives--;
            Debug.Log("Lives: " + lives);
        }
        else
        {
            Debug.Log("Game Over");
        }
    }
}
