using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    int a = 0;
    public GameObject UI;
    public void rotatakakakak()
    {
        a += 90;
        Vector3 papa = new Vector3(0, a, 0);
        transform.eulerAngles = papa;
    }
    private void Update()
    {
        //UI.transform.LookAt(-Camera.main.transform.position);
    }
}
