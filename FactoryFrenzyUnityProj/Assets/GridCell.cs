using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCell : MonoBehaviour
{
    private GameObject objOnCell; 
    // Start is called before the first frame update
    void Start()
    {
        objOnCell = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetObjOnCell()
    {
        return objOnCell;
    }

    public void SetObjOnCell(GameObject obj)
    {
        objOnCell = obj;
    }
}
