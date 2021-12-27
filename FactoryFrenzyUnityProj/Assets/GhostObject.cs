using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostObject : MonoBehaviour
{
    [SerializeField] LayerMask layermask;
    // Update is called once per frame
    void Update()
    {
        //do the ray stuff
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var hitInfo, Mathf.Infinity, layermask))
        {
            Vector3 pos = hitInfo.point;
            pos.y = 0.1f;

            transform.position = pos;
        }
    }
}
