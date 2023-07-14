using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour
{
    public Move move;
    public float ustLimit;
    public float sagLimit;
    Vector3 mousePosition;
    public GameObject rufus;
    public GameObject sag;
    public GameObject sol;
    public GameObject ust;
    public GameObject alt;

    Vector3 BeforePos;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();
    }
    private void OnMouseDrag()
    {
        LastPos(Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition));
    }
    void LastPos(Vector3 GoPos)
    {
        if (GoPos.x > sagLimit)
        {
            GoPos = new Vector3(sagLimit, 1, GoPos.z);
        }
        if (GoPos.x < -sagLimit)
        {
            GoPos = new Vector3(-sagLimit, 1, GoPos.z);
        }
        if (GoPos.z < -ustLimit)
        {
            GoPos = new Vector3(GoPos.x, 1, -ustLimit);
        }
        if (GoPos.z > ustLimit)
        {
            GoPos = new Vector3(GoPos.x, 1, ustLimit);
        }
        /*

        if (GoPos.x > rufus.transform.position.x - (rufus.transform.localScale.x + transform.localScale.x)/2
            &&
            GoPos.x < rufus.transform.position.x + (rufus.transform.localScale.x + transform.localScale.x) / 2)
        {

            if (
            BeforePos.x < rufus.transform.position.x - (rufus.transform.localScale.x + transform.localScale.x) / 2
            ||
            BeforePos.x > rufus.transform.position.x + (rufus.transform.localScale.x + transform.localScale.x) / 2)
            {

                if (transform.position.x < rufus.transform.position.x)
                {
                    GoPos = new Vector3(rufus.transform.position.x - (rufus.transform.localScale.x + transform.localScale.x) / 2, 1, GoPos.z);
                }
                if (transform.position.x > rufus.transform.position.x)
                {
                    GoPos = new Vector3(rufus.transform.position.x + (rufus.transform.localScale.x + transform.localScale.x) / 2, 1, GoPos.z);
                }
            }
            
        }

        
        if (GoPos.z > rufus.transform.position.z - (rufus.transform.localScale.z + transform.localScale.z) / 2
            &&
            GoPos.z < rufus.transform.position.z + (rufus.transform.localScale.z + transform.localScale.z) / 2)
        {
            if (
            BeforePos.z < rufus.transform.position.z - (rufus.transform.localScale.z + transform.localScale.z) / 2
            ||
            BeforePos.z > rufus.transform.position.z + (rufus.transform.localScale.x + transform.localScale.z) / 2)
            {
                
                if (transform.position.z < rufus.transform.position.z)
                {
                    GoPos = new Vector3(GoPos.x, 1, rufus.transform.position.z - (rufus.transform.localScale.z + transform.localScale.z) / 2);
                }
                if (transform.position.z > rufus.transform.position.z)
                {
                    GoPos = new Vector3(GoPos.x, 1, rufus.transform.position.z + (rufus.transform.localScale.z + transform.localScale.z) / 2);
                }
            }
        }
        */
        if (GoPos.x > rufus.transform.position.x - (rufus.transform.localScale.x + transform.localScale.x) / 2
            &&
            GoPos.x < rufus.transform.position.x + (rufus.transform.localScale.x + transform.localScale.x) / 2
            &&
            GoPos.z > rufus.transform.position.z - (rufus.transform.localScale.z + transform.localScale.z) / 2
            &&
            GoPos.z < rufus.transform.position.z + (rufus.transform.localScale.z + transform.localScale.z) / 2
            &&
            transform.position.x > rufus.transform.position.x - (rufus.transform.localScale.x + transform.localScale.x) / 2
            &&
            transform.position.x < rufus.transform.position.x + (rufus.transform.localScale.x + transform.localScale.x) / 2
            &&
            transform.position.z > rufus.transform.position.z - (rufus.transform.localScale.z + transform.localScale.z) / 2
            &&
            transform.position.z < rufus.transform.position.z + (rufus.transform.localScale.z + transform.localScale.z) / 2)
        {
            transform.position = BeforePos;
            return;
        }



        transform.position = new Vector3(GoPos.x, transform.localScale.y / 2, GoPos.z);
        BeforePos = new Vector3(GoPos.x, transform.localScale.y / 2, GoPos.z);
    }

    public void Limits(float length, float width)
    {
        sagLimit = length * 5 - transform.localScale.x/2; 
        ustLimit = width * 5 - transform.localScale.z/2;
    }

}
