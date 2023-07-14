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
        transform.localScale = new Vector3(length/5, 1, width/5);
    }

}
