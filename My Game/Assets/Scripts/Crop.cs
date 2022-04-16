using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crop : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        EnemyScript enemyScript = other.GetComponent<EnemyScript>();

        if(other.tag == "Enemy" && enemyScript.isFull == false)
        {
            Destroy(gameObject);  
            enemyScript.isFull = true;
        }
    }
}
