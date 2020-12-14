using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalSpawn : MonoBehaviour
{
    public GameObject health;
    public Transform objectPoint;
    public GameObject HealthParticles;
    public void Collect()
    {
        // Destroy(health);
        Instantiate(HealthParticles, objectPoint.position, objectPoint.rotation);
    }
}
