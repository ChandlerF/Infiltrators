using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomInAndOut : MonoBehaviour
{

    public Camera camera;
    public float MinZoom;
    public float MaxZoom;

    
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (camera.orthographicSize > MinZoom)
            {
                camera.orthographicSize--;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (camera.orthographicSize < MaxZoom)
            {
                camera.orthographicSize++;
            }
        }

    }
}
