using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    Light lamp;
    
    void Start()
    {

        lamp = GetComponent<Light>();
    }

    
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            lamp.enabled = !lamp.enabled;
        }
    } 
      

}