using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public struct Stat
{
    public Action OnDie;
    public float Hp
    {
        get { return hp; }
        set
        {
            if (0 < value && value <= MaxHp)
                hp = value;
            else if (MaxHp < value)
                hp = MaxHp;
            else if (hp < value)
                OnDie();

        }
    }
    public float MaxHp;
    public float Dmg
    {
        get { return dmg; }
    }



    [Header("Stat")]
    [SerializeField] private float hp;
    [Tooltip("Damage")]
    [SerializeField] private float dmg;
    [Tooltip("Attack Speed")]
    [SerializeField] private float ats;

}
public class Dice
{
    public List<GameObject> eyes = new List<GameObject>();

    public DiceData diceData;

    private void Start()
    {

    }
    public Dice Combine(Dice firstDice, Dice secondDice)
    {
        if(firstDice.diceData.count == secondDice.diceData.count)
        {
            Dice dice = null;
            
        }
        return null;
    }
}