using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public float speed = 40f;
    private Rigidbody bulletBody;
    public float bulletTimmer = 1f;
    public int damage = 10;


    private void Start()
    {
        bulletBody = this.GetComponent<Rigidbody>();
        bulletBody.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(bulletTimmer > 0)
        {
            bulletTimmer -= Time.deltaTime;
        }
        
        if (bulletTimmer <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider hitInfo)
    {
        EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
