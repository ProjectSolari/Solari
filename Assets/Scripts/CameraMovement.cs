using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float zoomSpeed = 1;

    void Start()
    {
        
    }

    
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.position = new Vector3(transform.position.x + x, zoomSpeed * -Input.mouseScrollDelta.y + transform.position.y, transform.position.z + y);



    }
}
