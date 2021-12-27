using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private GameObject cell;

    [SerializeField] private int gridWidth;
    [SerializeField] private int gridHeight;

    // Start is called before the first frame update
    void Start()
    {
        GameObject cacheCell = null;
        for (int x = 0; x < gridWidth; x++)
        {
            for (int z = 0; z < gridHeight; z++)
            {
                cacheCell = Instantiate(cell, this.transform);
                cacheCell.transform.position = new Vector3(x, 0, -z);
            }
        }

        Camera.main.transform.position = new Vector3(gridWidth / 2, Camera.main.transform.position.y, -gridHeight / 2);
    }

    // Update is called once per frame
    void Update()
    {
        //shoot a ray with layercast to hit on grid cells
        //get grid cell
    }
}
