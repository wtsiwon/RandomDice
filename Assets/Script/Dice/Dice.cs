using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;


[Serializable]
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
public class Dice : MonoBehaviour
{
    public List<GameObject> eyes = new List<GameObject>();

    [SerializeField] private DiceData diceData;

    

    public DiceData DiceData
    {
        get
        {
            return diceData;
        }
    }

    private void Start()
    {

    }
    
}