﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marine : MonoBehaviour
{

    private float Speed;
    public float MinSpeed;
    public float MaxSpeed;
    public GameObject RadarScript;
    public float StopDistance;

    void Start()
    {
        Speed = Random.Range(MaxSpeed, MinSpeed);

    }

    void Update()
    {
        if (RadarScript.GetComponent<FindingNearestEnemy>().ClosestEnemy != null)
        {
            float DistanceBetween = Vector3.Distance(transform.position, RadarScript.GetComponent<FindingNearestEnemy>().ClosestEnemy.position);
            if (DistanceBetween > StopDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, RadarScript.GetComponent<FindingNearestEnemy>().ClosestEnemy.transform.position, Speed * Time.deltaTime);
            }
        }
    }
}
