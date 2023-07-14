using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 mousePosition;
	Ray ray;
	RaycastHit hit;
    public GameObject target;
    public GameObject bos;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(Vector3.zero);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "obj")
                {
                    mousePosition = Input.mousePosition - GetMousePos();
                    target = hit.transform.gameObject;
                    Debug.Log(hit.transform.tag);
                }
            }
        }
        if (Input.GetMouseButton(0))
        {
            target.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
            target.transform.position = new Vector3(target.transform.position.x, target.transform.localScale.y/2 , target.transform.position.z);
        }
        if (Input.GetMouseButtonUp(0))
        {
            target = bos;
        }

    }
}
