using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crop : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>(); 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        EnemyScript enemyScript = other.GetComponent<EnemyScript>();
        
        if(other.tag == "Enemy" && enemyScript.isFull == false)
        {
            Destroy(gameObject);  
            enemyScript.isFull = true;
            gameManager.UpdateScore(1);
        }
    }

    
}
