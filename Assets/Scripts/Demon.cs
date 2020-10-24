using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demon : MonoBehaviour
{

    private float Speed;
    public float MinSpeed;
    public float MaxSpeed;
    public GameObject RadarScript;

    void Start()
    {
        Speed = Random.Range(MaxSpeed, MinSpeed);
    }

    void Update()
    {
        if (RadarScript.GetComponent< FindingNearestEnemy>().ClosestEnemy != null)
        {
                transform.position = Vector2.MoveTowards(transform.position, RadarScript.GetComponent<FindingNearestEnemy>().ClosestEnemy.transform.position, Speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(col.gameObject.name);
        if (col.gameObject.tag == ("MarineHitbox"))
        {
            //Debug.Log(col.gameObject.name);
            Destroy(col.gameObject.transform.parent.gameObject);
        }
    }
}
