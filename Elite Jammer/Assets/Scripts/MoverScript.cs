using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    private float x, y, z;
    public float speed;
    private void Start()
    {
        Debug.Log("Wakey, Wakey you fool!");
    }

    private void Update()
    {
        Debug.Log("Turn off game.");
        x = Input.GetAxis("Horizontal")* Time.deltaTime;
        y = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(speed * x,speed * y,z);
    }
}
