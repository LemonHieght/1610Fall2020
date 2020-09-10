using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

[CreateAssetMenu]
public class FloatScript : ScriptableObject
{
    public float value = 1f;

    public void ChangeValue(float number)
    {
        value += number;
    }
}
