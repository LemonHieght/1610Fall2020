using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalSpawn : MonoBehaviour
{
    public GameObject collection;
    public Transform objectPoint;
    public GameObject particles;
    public void Collect()
    {
        // Destroy(health);
        Instantiate(particles, objectPoint.position, objectPoint.rotation);
    }
}
