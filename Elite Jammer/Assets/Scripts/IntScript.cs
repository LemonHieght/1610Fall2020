using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

[CreateAssetMenu]
public class IntScript : ScriptableObject
{
    public int value = 1;

    public void ChangeValue(int number)
    {
        value += number;
    }
}
