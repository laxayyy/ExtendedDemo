using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSCript : MonoBehaviour
{
    CharacterController thisCubeCharacterController;
    int speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");

        thisCubeCharacterController = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxis("Horizontal"));

        thisCubeCharacterController.Move(speed* Input.GetAxis("Horizontal")*transform.right);
        thisCubeCharacterController.Move(speed * Input.GetAxis("Vertical") * transform.forward);
    }
}
