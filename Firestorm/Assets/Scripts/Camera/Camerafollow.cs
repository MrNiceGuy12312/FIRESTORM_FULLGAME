using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    private Transform playerTransform;
    public float offset;
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
    void LateUpdate()
    {
        //camera's position in a variable temp
        Vector3 temp = transform.position;
        //makes the camera follow the x and y of the player 
        temp.x = playerTransform.position.x;
        temp.y = playerTransform.position.y;
        //gives the option to change the offset of the camera
        temp.x  += offset;
        temp.y += offset;

        transform.position = temp;

        
    }
}
