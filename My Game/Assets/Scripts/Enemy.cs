using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1;

    public GameObject[] cropArray;
    private Rigidbody2D enemyRb;

    private void Start() 
    {
        enemyRb = GetComponent<Rigidbody2D>(); 
        cropArray = GameObject.FindGameObjectsWithTag("Crop");   
    }

    private void Update()
    {
        //moves enemy toward closest crop
        transform.position = Vector2.Lerp(transform.position, FindClosestCrop().transform.position, Time.deltaTime * speed);
    }

    private GameObject FindClosestCrop()
    {
        GameObject cropMin = null; //current closest object
        float minDist = Mathf.Infinity; //current closest distance

        foreach(GameObject crop in cropArray)
        {
            if(crop != null) //if crop is active
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
}
