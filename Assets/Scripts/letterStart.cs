using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class letterStart : MonoBehaviour
{
    public Image startLetter;

    public void Start() 
    {
        startLetter.enabled = true;   
        Debug.Log("çalıştı") ;
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            startLetter.enabled = false;
        }
    }
}
