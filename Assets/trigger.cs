using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public bool isTrigger = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "obj")
        {
            isTrigger = true;
            transform.parent.GetComponent<Movable>().rufus = other.gameObject;
            Debug.Log("allah");
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.transform.tag == "obj")
        {
            isTrigger = false; ;
        }
    }
}
