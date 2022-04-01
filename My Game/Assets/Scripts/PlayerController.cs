using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
 
    private float horizontalInput = 5;
    private float verticalInput = 5;

    private float sideBound = 8;
    private float topBound = 4;
    

    void Start()
    {
        
    }

    
    void Update()
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

        //moves player left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        //moves player up and down
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);
    }
}
