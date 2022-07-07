using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBox : MonoBehaviour
{
    //public GameObject canvas;
    public int textBoxPointer;
     private void Start()
    {
        //GameObject initialCanvas = Instantiate(canvas, Vector3.zero, Quaternion.identity);
    }
    private void Update()
    {
        foreach(Transform child in this.transform)
        {
            if(child.GetChild(0).childCount != 4)
            {
                textBoxPointer = child.GetComponent<canvasData>().canvasID;
            }
        }
    }

}
