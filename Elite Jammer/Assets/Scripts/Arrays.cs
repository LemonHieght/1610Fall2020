using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    int[] myIntArray = new int [5];
    
    int[] quickArray = {10, 20, 30, 40, 50, 60}; 
    
    public GameObject[] player;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
        myIntArray[0] = 12;
        myIntArray[1] = 24;
        myIntArray[2] = 36;
        myIntArray[3] = 48;
        myIntArray[4] = 60;
        myIntArray[5] = 72;
        foreach (int i in myIntArray)
        {
            print (i);
        }

        quickArray[3] = 40;

        player = GameObject.FindGameObjectsWithTag("Player");
        for (int i = 0; i < player.Length; i++)
        {
            Debug.Log("Player Number " + i + " is named " + player[i].name);
        }
    }
}
