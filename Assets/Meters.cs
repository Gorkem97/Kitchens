using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Meters : MonoBehaviour
{
    public TMP_InputField wid;
    public TMP_InputField leg;

    public GameObject yuay;


    float width;
    float length;
    void Start()
    {
        
    }

    void Update()
    {
    }
    public void Widthing()
    {
        width = float.Parse(wid.text);
        Debug.Log(width);
    }
    public void Lengthing()
    {
        length = float.Parse(leg.text);
        Debug.Log(length);
    }
    public void Plane()
    {
        transform.localScale = new Vector3(length, 1, width);
        foreach (GameObject t in GameObject.FindGameObjectsWithTag("obj"))
        {
            t.GetComponent<Movable>().Limits(length, width);
        }
       // yuay.SetActive(false);
    }

}
