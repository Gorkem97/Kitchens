using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Xy : MonoBehaviour
{
    public TMP_InputField x;
    public TMP_InputField y;

    public MeshRenderer plane;
    public MeshRenderer mine;

    public Material real;
    public Material fake;
    public Material green;
    public Material red;

    public GameObject UI1;
    public GameObject UI2;

    bool isTrig = false;

    bool oldu = true;
    bool active = false;
    Vector3 original;
    bool disaridaMi = true;


    public LayerMask m_LayerMask;

    public void xler()
    {
        float a = float.Parse(x.text);
        transform.position = new Vector3(a, transform.localScale.y / 2, transform.position.z);
    }
    public void yler()
    {
        float a = float.Parse(y.text);

        transform.position = new Vector3(transform.position.x, transform.localScale.y / 2, a);
    }
    public void baslat()
    {
        GetComponent<rigidMove>().yazi = true;
        original = transform.position;
        active = true;
        mine.material = fake;
        UI1.SetActive(false);
        UI2.SetActive(true);
    }
    public void bitir()
    {
        if (isTrig)
        {
            return;
        }
        GetComponent<rigidMove>().yazi = false;
        active = false;
        mine.material = real;
        UI1.SetActive(true);
        UI2.SetActive(false);
    }
    private void Update()
    {
        if (disaridaMi && Input.GetMouseButtonDown(0) && active == true)
        {
            transform.position = original;
            active = false;
            mine.material = real;
            UI1.SetActive(true);
            UI2.SetActive(false);
            GetComponent<rigidMove>().yazi = false;
        }
        Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, transform.localScale / 2, Quaternion.identity) ;
        if (hitColliders != null && hitColliders.Length > 1 && active)
        {
            isTrig = true;
            plane.material = red;
        }
        else
        {
            isTrig = false;
            plane.material = green;
        }
    }
    private void OnMouseEnter()
    {
        disaridaMi = false;
    }
    private void OnMouseExit()
    {
        disaridaMi = true;
    }



}
