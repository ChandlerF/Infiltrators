using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonSpawner : MonoBehaviour
{
    public GameObject Demon;
    public float AmountOfDemons;
    private Vector3 SpawnLocation;
    public GameObject[] SpawnPoints;

    void Start()
    {
        SpawnDemons();
    }
    

    private void SpawnDemons()
    {
        for (int x = 0; x < AmountOfDemons; x++)
        {
            SpawnLocation = SpawnPoints[x].transform.position;
            Instantiate(Demon, SpawnLocation, Quaternion.identity);

        }
    }
}
