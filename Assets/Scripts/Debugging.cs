using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugging : MonoBehaviour
{
    public GameObject Wall; 

    public GameObject DropPod;

    public GameObject DemonSpawner;
    private Vector2 SpawnPosition;
    void Start()
    {
        
    }

    void Update()
    {

        // ------------------------------------------------------------------------------------------------
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);  //Gets mouse position
        SpawnPosition = new Vector2(worldPoint.x, worldPoint.y);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(DropPod, SpawnPosition, Quaternion.identity);
        }

        // ------------------------------------------------------------------------------------------------ Spawns DropShips with Left Mouse ^

        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(DemonSpawner, SpawnPosition, Quaternion.identity);
        }

        // ------------------------------------------------------------------------------------------------ Spawns Demons with Right Mouse ^

        if (Input.GetMouseButton(2))
        {
            Instantiate(Wall, SpawnPosition, Quaternion.identity);
        }

        // ------------------------------------------------------------------------------------------------ Spawns Walls with Middle Mouse ^

    }
}
