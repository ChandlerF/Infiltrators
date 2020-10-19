using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarineDropShip : MonoBehaviour
{

    public GameObject Marine;
    public float StartTimeUntilSpawns;
    private float TimeUntilSpawns;
    public float AmountOfMarines;
    private bool StartedSpawning = false;
    private Vector3 SpawnLocation;
    public GameObject[] SpawnPoints;

    void Start()
    {
        TimeUntilSpawns = StartTimeUntilSpawns;
        //SpawnPoints = GameObject.FindGameObjectsWithTag("MarineDropShipSpawnPoint");

    }

    void Update()
    {
        if(TimeUntilSpawns > 0)
        {
            TimeUntilSpawns -= Time.deltaTime;
        }
        if (TimeUntilSpawns <= 0 && StartedSpawning == false)
        {
            SpawnMarines();
        }
    }

    private void SpawnMarines()
    {
        StartedSpawning = true;
        for(int x = 0; x < AmountOfMarines; x++)
        {
            SpawnLocation = SpawnPoints[x].transform.position;
            Instantiate(Marine, SpawnLocation, Quaternion.identity);

        }
    }
}
