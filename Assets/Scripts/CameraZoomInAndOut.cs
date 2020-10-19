using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomInAndOut : MonoBehaviour
{

    public Camera TheCamera;
    public float MinZoom;
    public float MaxZoom;

    
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (TheCamera.orthographicSize > MinZoom)
            {
                TheCamera.orthographicSize--;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (TheCamera.orthographicSize < MaxZoom)
            {
                TheCamera.orthographicSize++;
            }
        }

    }
}
