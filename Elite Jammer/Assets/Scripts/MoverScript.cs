using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    private float x, y, z;
    public float speed = 5;
    public float jumpPower = 5;
    public Rigidbody myRigidBody;
    public bool ground;
    public Animator animator;

    void Start()
    {
        Debug.Log("Wakey, Wakey you fool!");
        myRigidBody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Debug.Log("Turn off game.");
        x = Input.GetAxis("Horizontal")* Time.deltaTime;

        // y = Input.GetAxis("Vertical") * Time.deltaTime;
        if(Input.GetButtonDown("Jump") && ground)
        {
            myRigidBody.velocity = Vector3.up * jumpPower;
            ground = false;
        }
        
        transform.Translate(speed * x,speed * y,z);
        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));
    }

    void OnCollisionStay()
    {
        ground = true;
    }
}
