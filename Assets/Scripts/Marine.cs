using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marine : MonoBehaviour
{

    public float Speed;
    public FindingNearestEnemy RadarScript;
    void Update()
    {
        if(RadarScript.ClosestEnemy != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, RadarScript.ClosestEnemy.position, Speed * Time.deltaTime);
        }
    }
}
