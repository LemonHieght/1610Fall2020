using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int aliveEnemies;
    public int numEnemies = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < numEnemies; x++)
        {
            Debug.Log("creating enemy number:" + x);
        }
        numEnemies = aliveEnemies;
    }

    // Update is called once per frame
    void Update()
    {
        while (aliveEnemies <= 0)
        {
            Debug.Log("All enemies are Dead!");
        }
    }
}
