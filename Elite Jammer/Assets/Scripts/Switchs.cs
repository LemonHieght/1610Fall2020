using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switchs : MonoBehaviour
{
    public int sickness= 4;

    void Healthy()
    {
        switch (sickness)
        {
            case 4:
                print("You're as healthy as an ox");
                break;
            case 3:
                print("I guess you feel fine");
                break;
            case 2:
                print("You look a little under the weather");
                break;
            case 1:
                print("You look like walking death");
                break;
            default:
                print("No sickness level detected");
                break;
        }
    }
}
