using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blast : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bast;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= 10)
        {
         bast.SetActive(true);
     }   
    }
}
