using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour
{

    public GameObject Bullet;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void Shoot()
    {
        Instantiate(Bullet, gameObject.transform.position, Quaternion.identity);
    }
}
