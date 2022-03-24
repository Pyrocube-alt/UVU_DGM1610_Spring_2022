using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public GameObject projectilePrefab;

    private float barrier = 10;


    // Update is called once per frame
    void Update()
    {
        //moves player left and right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        //keep the player in bounds
        if (transform.position.x < -barrier)
        {
            transform.position = new Vector3(-barrier, transform.position.y, transform.position.z);
        }
        if (transform.position.x > barrier)
        {
            transform.position = new Vector3(barrier, transform.position.y, transform.position.z);
        }

        //Launch a projectile from the player
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
