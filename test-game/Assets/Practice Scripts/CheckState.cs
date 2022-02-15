using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckState : MonoBehaviour
{
    public GameObject myOject;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Active Self: " + myOject.activeSelf);
        Debug.Log("Active in Hierarchy" + myOject.activeInHierarchy);
    }

}
