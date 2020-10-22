using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marine : MonoBehaviour
{

    public float Speed;
    public FindingNearestEnemy RadarScript;
    public float StopDistance;
    //public float FollowDistance;

    void Update()
    {
        if(RadarScript.ClosestEnemy != null)
        {
            float DistanceBetween = Vector3.Distance(transform.position, RadarScript.ClosestEnemy.position);
            if (DistanceBetween > StopDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, RadarScript.ClosestEnemy.position, Speed * Time.deltaTime);
            }
        }
    }
}
