using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat 
{
    [SerializeField]
    private int baseValue;

    private List<float> modifiers = new List<float>();

    public float GetValue() {
        float finalValue = baseValue;
        modifiers.ForEach(x => finalValue += x);
        UnityEngine.Debug.Log("This is the base value: "  + baseValue);
        return finalValue;
    }

    public void AddModifier(float modifier){
        if (modifier != 0) {
            modifiers.Add(modifier);
        }
    }

    public void RemoveModifier(float modifier) {
        if (modifier != 0) {
            modifiers.Remove(modifier);
        }
    }
}
