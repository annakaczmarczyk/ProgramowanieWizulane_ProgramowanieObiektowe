using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruch : MonoBehaviour
{
    public float speed;
    float x, y;
    void FixedUpdate()
    {
     
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Translate(x * speed * Time.fixedDeltaTime, y * speed * Time.deltaTime, 0);
        
    }
}
