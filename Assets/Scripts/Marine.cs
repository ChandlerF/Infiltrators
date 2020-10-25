using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marine : MonoBehaviour
{

    private float Speed;
    public float MinSpeed;
    public float MaxSpeed;
    public GameObject RadarScript;
    public float StopDistance;

    public float StartTimerToShoot;
    private float TimerToShoot;
    public Rifle RifleScript;

    void Start()
    {
        Speed = Random.Range(MaxSpeed, MinSpeed);
        TimerToShoot = StartTimerToShoot;
    }

    void Update()
    {
        Transform CloseEnemy = RadarScript.GetComponent<FindingNearestEnemy>().ClosestEnemy;
        if (CloseEnemy != null)
        {
            float DistanceBetween = Vector3.Distance(transform.position, CloseEnemy.position);
            if (DistanceBetween > StopDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, CloseEnemy.position, Speed * Time.deltaTime);
            } else if (TimerToShoot <= 0)
            {
                RifleScript.Shoot();
                TimerToShoot = StartTimerToShoot;
            }

            if(TimerToShoot > 0)
            {
                TimerToShoot -= Time.deltaTime;
            }
        }
    }
}
