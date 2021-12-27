using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;


    private bool isMouseOverUI;
    public void SetIsMouseOverUI(bool b) { isMouseOverUI = b; }

    bool isGhost;
    GameObject ghostObj;
    public void SetGhostObject(GameObject obj)
    { 
        ghostObj = Instantiate(obj); 
        isGhost = true; 
    }

    private GameObject placeObject;
    public void SetPlaceObject(GameObject obj) { placeObject = obj; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //shoot a ray down from the camera
        if (Input.GetMouseButtonDown(0))
        {
            //if mouse is over the UI abort function
            if (isMouseOverUI)
                return;

            if (!isGhost)
                return;

            //do the ray stuff
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hitInfo, Mathf.Infinity, layerMask))
            {
                GridCell gridCell = hitInfo.transform.GetComponent<GridCell>();

                //if the cell is empty
                if (gridCell.GetObjOnCell() == null)
                {
                    //put a conveyor belt
                    gridCell.SetObjOnCell(Instantiate(placeObject, gridCell.transform));

                    Destroy(ghostObj);
                    placeObject = null;
                    isGhost = false;
                }

                
            }
        }
    }

    public GameObject ShootRay(LayerMask layermask)
    {

        return null;
    }
}
