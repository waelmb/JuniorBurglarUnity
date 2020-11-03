using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public Stat dex;
    public Stat str;

    /*private void Update()
    {
        *//*dex.GetValue();*//*
    }*/

    public int IncreaseSpeed()
    {
        return dex.GetValue();
    }
}
