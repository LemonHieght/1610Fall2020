using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastShooting : MonoBehaviour
{
    public int damage = 10;
    public float fireRate = 0.2f;
    public float weaponRange = 50f;
    public float hitforce = 100f;
    public Transform weaponTip;
    
    private WaitForSeconds shotTime = new WaitForSeconds(0.07f);
    private LineRenderer laser;
    private float nextShoot;

    void Start()
    {
        laser = GetComponent<LineRenderer>();
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextShoot)
        {
            nextShoot = Time.time + fireRate;
            StartCoroutine(ShotEffect());
            
        }
    }

    private IEnumerator ShotEffect()
    {
        laser.enabled = true;
        yield return shotTime;
        laser.enabled = false;
    }
}
