using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject bulletPreFab;
    // public Animator animator;
    private float timer;
    private bool loaded;
    
    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0)
        {
            loaded = true;
        }
        if (Input.GetButtonDown("Fire1") && loaded == true)
        {
            Shooting();
        }
        // animator.SetBool("fire", Input.GetButtonDown("Fire1"));
    }

    void Shooting()
    {
        Instantiate(bulletPreFab, firePoint.position , firePoint.rotation);
        timer = 1;
        loaded = false;

    }
}
