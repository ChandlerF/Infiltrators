using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Testing : MonoBehaviour
{
   // [SerializeField] private HeatMapVisual HeatMapVisual;
    private Grid grid;

    private void Start()
    {
        grid = new Grid(20, 100, 6f, Vector3.zero);

     //   HeatMapVisual.SetGrid(grid);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 Position = UtilsClass.GetMouseWorldPosition();
        //    grid.AddValue(Position, 100, 2, 25);
        }
    }






































    /*
    private Grid grid;
    public GameObject DropPod;
    private Vector2 SpawnLocation;  //Snaps to grid

    private void Start()
    {
        grid = new Grid(20, 4, 4f, new Vector3(20, 0));
    }

    private void Update()
    {
        SpawnLocation.x = Mathf.Round(UtilsClass.GetMouseWorldPosition().x);
        SpawnLocation.y = Mathf.Round(UtilsClass.GetMouseWorldPosition().y);


        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(UtilsClass.GetMouseWorldPosition(), grid.GetValue(UtilsClass.GetMouseWorldPosition()) + 1);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
            Instantiate(DropPod, SpawnLocation, Quaternion.identity);
        }

    }*/
}
