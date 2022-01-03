using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generaterandom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {
        // foreach (Transform o in gameObject.transform)
        // {
        //     o.forward = o.position - Camera.main.transform.position;
        //     // o.up = transform.right;
        // }

    }

    public void tracked()
    {
        Random.seed = Time.frameCount;
        // foreach (Transform o in gameObject.transform)
        // {
        //     o.position = new Vector3();
        // }

        
        
    }
}
