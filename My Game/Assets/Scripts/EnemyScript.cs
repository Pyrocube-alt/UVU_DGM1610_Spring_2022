using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed = 1;
    public bool isFull = false;


    public GameObject[] cropArray;
    private GameObject enemyExit;
    public AudioClip crunchSound;
    private AudioSource enemyAudio;
    private GameManager gameManager;
    private SpawnManager spawnManager;
    private Rigidbody2D enemyRb;
    private SpriteRenderer enemySprite;
    

    private void Start() 
    {
        enemyRb = GetComponent<Rigidbody2D>(); 
        enemySprite = GetComponent<SpriteRenderer>();
        enemyAudio = GetComponent<AudioSource>();
        
        cropArray = GameObject.FindGameObjectsWithTag("Crop");   
        enemyExit = GameObject.FindGameObjectWithTag("Exit");
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    private void Update()
    {
        MoveEnemy();
    }

    void MoveEnemy()
    {
        Vector3 oldPos = transform.position;

        //moves enemy toward closest crop unless enemy is full, then leave 
        if (isFull == false)
        {
            transform.position = Vector2.Lerp(transform.position, FindClosestCrop().transform.position, Time.deltaTime * speed);
        }
        else if (isFull == true)
        {
            transform.position = Vector2.Lerp(transform.position, enemyExit.transform.position, Time.deltaTime * speed);  
        }
        //flips sprite based on direction
        if(oldPos.x - transform.position.x < 0)
        {
            enemySprite.flipX = true;
        }
        else 
        {
            enemySprite.flipX = false;
        } 
    }


    //returns closest crop to enemy 
    private GameObject FindClosestCrop()
    {
        GameObject cropMin = null; //current closest crop
        float minDist = Mathf.Infinity; //current closest distance

        foreach(GameObject crop in cropArray)
        {
            if(crop != null & isFull == false) //if crop is active and isFull is false, then find closest crop
            {
                float dist = Vector3.Distance(crop.transform.position, transform.position);
                if (dist < minDist)
                {
                cropMin = crop;
                minDist = dist;
                }
            }
        }
        return cropMin;
    }

    //if enemy colliders with player or exit, destroy enemy
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Exit"))
        {
            Destroy(gameObject); 
        }
        if (other.CompareTag("Crop") && !isFull)
        {
            enemyAudio.PlayOneShot(crunchSound, 0.5f);
        }
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            gameManager.UpdateKill(1);
            spawnManager.BloodSplatter();
        }   
        
    } 

    
}
