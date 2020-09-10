using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Triggers : MonoBehaviour
{
    public UnityEvent triggerEnter;
    public UnityEvent triggerExit;
    public UnityEvent triggerStay;
    
    void OnTriggerEnter(Collider other)
    {
        triggerEnter.Invoke();
    }

    void OnTriggerExit(Collider other)
    {
        triggerExit.Invoke();
    }

    void OnTriggerStay(Collider other)
    {
       triggerStay.Invoke(); 
    }
}
