using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public FloatScript healthBar;

    public float health;

    public bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        healthBar.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        health = healthBar.value;
        if (health <= 0f)
        {
            FindObjectOfType<GameManger>().EndGame();
        }
    }
}
