using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindingNearestEnemy : MonoBehaviour
{
    private GameObject[] MultipleEnemies;
    public Transform ClosestEnemy;
    public bool EnemyContact;
    public string TagOfEnemy;


    void Start()
    {
        ClosestEnemy = null;
        EnemyContact = false;
    }

   /* void Update()
    {
        if(ClosestEnemy == null)
        {
            ClosestEnemy = GetClosestEnemy();
            
        }
        else
        {
            ClosestEnemy.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(1, 0.7f, 0, 1);
            EnemyContact = true;
        }
    }*/

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.isTrigger != true && collision.CompareTag(TagOfEnemy))
        {
            /*if(ClosestEnemy != null)
            {
                ClosestEnemy.gameObject.GetComponent<SpriteRenderer>().material.color = Color.white;
            }*/

            ClosestEnemy = GetClosestEnemy();
            //ClosestEnemy.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(1, 0.7f, 0, 1);
            EnemyContact = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.isTrigger != true && collision.CompareTag(TagOfEnemy)) { 

            EnemyContact = false;
            //ClosestEnemy.gameObject.GetComponent<SpriteRenderer>().material.color = Color.white;
        }
    }

    private void OnDestroy()
    {
        /*if (ClosestEnemy != null)
        {
            ClosestEnemy.gameObject.GetComponent<SpriteRenderer>().material.color = Color.white;
        }*/
    }
    
    public Transform GetClosestEnemy()
    {
        MultipleEnemies = GameObject.FindGameObjectsWithTag(TagOfEnemy);
        float ClosestDistance = Mathf.Infinity;
        Transform trans = null;

        foreach(GameObject enemy in MultipleEnemies)
        {
            float CurrentDistance;
            CurrentDistance = Vector3.Distance(transform.position, enemy.transform.position);
            if(CurrentDistance < ClosestDistance)
            {
                ClosestDistance = CurrentDistance;
                trans = enemy.transform;
            }
        }
        return trans;
    }
}
