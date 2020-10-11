using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;


public class Grid
{
    private int Width;
    private int Height;
    private float CellSize;
    private Vector3 OriginPosition;
    private int[,] GridArray; //"[,]" defines a multidimensional array with 2 dimensions
    private TextMesh[,] DebugTextArray;




    public Grid(int Width, int Height, float CellSize, Vector3 OriginPosition)
    {
        this.Width = Width;
        this.Height = Height;
        this.CellSize = CellSize;
        this.OriginPosition = OriginPosition;
        GridArray = new int[Width, Height];
        DebugTextArray = new TextMesh[Width, Height];

        for(int x = 0; x < GridArray.GetLength(0); x++)  //Cycles through a multi dimensional array
        {
            for(int y = 0; y < GridArray.GetLength(1); y++)
            {
                DebugTextArray[x, y] = UtilsClass.CreateWorldText(GridArray[x, y].ToString(), null, GetWorldPosition(x, y) + new Vector3(CellSize, CellSize) * .5f, 30, Color.white, TextAnchor.MiddleCenter);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1), Color.white, 100f);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x + 1, y), Color.white, 100f);

            }
        }
        Debug.DrawLine(GetWorldPosition(0, Height), GetWorldPosition(Width, Height), Color.white, 100f);
        Debug.DrawLine(GetWorldPosition(Width, 0), GetWorldPosition(Width, Height), Color.white, 100f);

        //SetValue(2, 1, 56);

    }

    private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * CellSize + OriginPosition;
    }

    private void GetXY(Vector3 worldposition, out int x, out int y)
    {
        x = Mathf.FloorToInt((worldposition - OriginPosition).x / CellSize);
        y = Mathf.FloorToInt((worldposition - OriginPosition).y / CellSize);

    }

    public void SetValue(int x, int y, int value)
    {
        if(x >= 0 && y >= 0 && x < Width && y < Height)
        {
            GridArray[x, y] = value;
            DebugTextArray[x, y].text = GridArray[x, y].ToString();
        }
    }
    public void SetValue(Vector3 worldposition, int value){
        int x, y;
        GetXY(worldposition, out x, out y);
        SetValue(x, y, value);
    }

    public int GetValue(int x, int y)
    {
        if (x >= 0 && y >= 0 && x < Width && y < Height)
        {
            return GridArray[x, y];
        }
        else
        {
            return 0;
        }
    }

    public int GetValue(Vector3 worldposition)
    {
        int x, y;
        GetXY(worldposition, out x, out y);
        return GetValue(x, y);
    }
}
