using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Triggers : MonoBehaviour
{
    public UnityEvent triggerEnter;
    public UnityEvent triggerExit;
    public UnityEvent triggerStay;
    
    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Player")
        {
            triggerEnter.Invoke(); 
        }
    }

    void OnTriggerExit(Collider target)
    {
        if (target.tag == "Player")
        {
            triggerExit.Invoke(); 
        };
    }

    void OnTriggerStay(Collider target)
    {
        if (target.tag == "Player")
        {
            triggerStay.Invoke(); 
        }
    }
}
