using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjUI : MonoBehaviour
{
    public bool isOn = false;
    public rigidMove parent;
    private void OnMouseOver()
    {
        isOn = true;
    }
    private void OnMouseExit()
    {
        isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn && Input.GetMouseButtonDown(0))
        {
            parent.IsOn();
        }
    }
}
