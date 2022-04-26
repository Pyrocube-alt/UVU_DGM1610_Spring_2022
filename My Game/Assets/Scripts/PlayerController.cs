using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public bool isGameOver = false;
 
    private float horizontalInput = 5;
    private float verticalInput = 5;
    private float sideBound = 8;
    private float topBound = 4;

    public AudioClip squishSound;
    private BoxCollider2D boxCollider;
    private Rigidbody2D playerRb;
    private AudioSource playerAudio;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        playerRb = GetComponent<Rigidbody2D>();
        playerAudio = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        MovePlayer();
        GameOver();
    }

    void MovePlayer()
    {
        //keep player in bounds on x axis
        if(transform.position.x >= sideBound)
        {
            transform.position = new Vector3(sideBound, transform.position.y, 0);
        }
        else if(transform.position.x <= -sideBound)
        {
            transform.position = new Vector3(-sideBound, transform.position.y, 0);
        }

        //keep player in bounds on y axis
        if(transform.position.y >= topBound)
        {
            transform.position = new Vector3(transform.position.x, topBound, 0);
        }
        else if(transform.position.y <= -topBound)
        {
            transform.position = new Vector3(transform.position.x, -topBound, 0);
        }

        if(isGameOver == false)
        {
            //moves player left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        //moves player up and down
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);
        }
        

    }

    void GameOver()
    {
        if(GameObject.FindGameObjectWithTag("Crop") == null)
        {
            isGameOver = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Enemy"))
        {
            playerAudio.PlayOneShot(squishSound, 0.5f);
        }    
    }
}
