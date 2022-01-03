using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class gallery : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<Renderer>().isVisible)
        {
            float d = Vector3.Distance(transform.position, Camera.main.transform.position);
            if (d < 0.25f) {
                gameObject.GetComponent<VideoPlayer>().Play();
            }
        }
        else

        {
            gameObject.GetComponent<VideoPlayer>().Stop();
           }
    }
}
