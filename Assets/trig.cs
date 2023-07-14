using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trig : MonoBehaviour
{
    public bool isTrigger = false;

    private void OnTriggerStay(Collider other)
    {
        if(other.transform.tag == "coll" ||  other.transform.tag == "obj")
        {
            isTrigger = true;

        }
        else
        {
            isTrigger = false;
        }
    }
}
