using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public bool hasPowerup = false;

    private float powerupStrengh = 15;

    public GameObject powerIndicator;

    private Rigidbody playerRb;
    private GameObject focalPoint;
    private Vector3 indicatorOffset = new Vector3(0, -0.5f, 0);

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);

        powerIndicator.transform.position = transform.position + indicatorOffset;
    }

    //Player triggers powerup
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            powerIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
        }
    }

    //countdown for powerup
    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerIndicator.gameObject.SetActive(false);
    }

    // When player has power up, enemy gets bounced away
    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;

            enemyRigidbody.AddForce(awayFromPlayer * powerupStrengh, ForceMode.Impulse);
        }    
    }
}
