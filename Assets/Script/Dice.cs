using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Stat
{
    public float Hp
    {
        get { return hp; }
        set
        {
            if (0 < value && value <= MaxHp)
                hp = value;
            else if (MaxHp < value)
                hp = MaxHp;
            
        }
    }
    public float MaxHp;
    public float Dmg
    {
        get { return dmg; }
    }
    



    [SerializeField] private float hp;
    [SerializeField] private float dmg;

}
public class Dice
{
    
}
