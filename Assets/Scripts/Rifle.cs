﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour
{

    public GameObject Bullet;
    public GameObject RadarScript;

    //public SpriteRenderer MySpriteRenderer; Not using sprite renderer.flip because shoot point doesnt move with it

    public GameObject ShootPoint;
   
    void Update()
    {

        if (gameObject.transform.rotation.z < -0.75 || gameObject.transform.rotation.z > 0.75)  //Flips gun towards enemy if rotated enough
        {
            transform.localScale = new Vector3(.77f, -.77f, .77f);
        }
        else
        {
            transform.localScale = new Vector3(.77f, .77f, .77f);
        }

        
        




        if (RadarScript.GetComponent<FindingNearestEnemy>().ClosestEnemy != null)  //Rotates Gun towards enemy
        {  

            Vector3 Closest = RadarScript.GetComponent<FindingNearestEnemy>().ClosestEnemy.position;

            Closest.x -= gameObject.transform.position.x;
            Closest.y -= gameObject.transform.position.y;

            float angle = (Mathf.Atan2(Closest.y, Closest.x) * Mathf.Rad2Deg);
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        }
    }

    public void Shoot()
    {
        Instantiate(Bullet, ShootPoint.transform.position, gameObject.transform.rotation);
    }
}
