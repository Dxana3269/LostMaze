using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
   // private float speed = 100;
    public Transform player;
    public Vector3 cameraOffset;

    void Start()
    {
        cameraOffset = transform.position - player.transform.position;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = player.transform.position + cameraOffset;
        transform.position = newPosition;
        

    }
}