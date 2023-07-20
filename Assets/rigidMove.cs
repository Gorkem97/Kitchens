using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidMove : MonoBehaviour
{
    Vector3 mousePosition;
    public Rigidbody rb;
    bool start = false;
    bool dragLock = true;
    Vector3 GoPos = Vector3.zero;
    bool isOn = false;
    public GameObject DragBar;



    public Material real;
    public Material fade;
    public MeshRenderer Rhander;

    public bool yazi = false;
    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {

        if (dragLock && !yazi)
        {
            DragBar.SetActive(true);
        }
        if (!dragLock)
        {
            rb.isKinematic = false;
            rb.constraints = RigidbodyConstraints.None;
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            mousePosition = Input.mousePosition - GetMousePos();
            start = true;
        }
    }
    private void OnMouseDrag()
    {
        if (!dragLock)
        {
            GoPos = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);

            GoPos = new Vector3(GoPos.x, transform.localScale.y/2, GoPos.z);
        }
    }
    private void OnMouseUp()
    {
        if (!dragLock)
        {
            start = false;
            rb.velocity = Vector3.zero;
            rb.constraints = RigidbodyConstraints.FreezePosition;
            rb.isKinematic = true;
        }
    }
    private void Update()
    {
        
        if (!isOn && Input.GetMouseButtonDown(0))
        {
            DragBar.SetActive(false);
            dragLock = true;
            Rhander.material = real;
        }
        
    }
    private void OnMouseExit()
    {
        isOn = false;
    }
    private void OnMouseOver()
    {
        isOn = true;
    }

    private void FixedUpdate()
    {
        if (start)
        {
            rb.velocity = (GoPos - transform.position) * 10;
        }
    }
    public void Drag()
    {
        Rhander.material = fade;
        dragLock = false;
        DragBar.SetActive(false);
    }
    public void IsOn()
    {
        DragBar.SetActive(false);
        dragLock = true;
        Rhander.material = real;
    }
}
