using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject target;
    public float moveSpeed;
    private Vector3 targetPos;
    public float zValue;
    public float yValue;
    public float xValue;
    
    void FixedUpdate()
    {    
        targetPos = new Vector3 (target.transform.position.x - xValue,yValue,target.transform.position.z - zValue);
        transform.position = Vector3.Lerp (transform.position,targetPos,moveSpeed * Time.deltaTime);
    }
}
