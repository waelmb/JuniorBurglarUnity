using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterStats : MonoBehaviour
{
    public Stat dex;
    public Stat str;


    public float getDexValue()
    {
        float x = dex.GetValue();
        return x;
    }

    public float IncreaseSpeed(float runspeed)
    {
        float x = dex.GetValue();
        runspeed += x;
        //UnityEngine.Debug.Log("Current run speed value: " + x);
        return runspeed;
    }

    public float IncreaseStrength(float Strength)
    {
        float x = str.GetValue();
        Strength += x;
        return Strength;
    }

    

   /* public float getDexVal()
    {
        float x = dex.GetValue();
        return x;
    }

    public float getStrVal()
    {
        float x = str.GetValue();
        return x;
    }*/
}
