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
    public float AD
    {
        get { return ad; }
    }

    public float Ats
    {
        get { return ats; }
        set
        {
            Ats = value;
        }
    }


    [Header("Stat")]
    [SerializeField] private float hp;
    [Tooltip("Damage")]
    [SerializeField] private float ad;
    [Tooltip("Attack Speed")]
    [SerializeField] private float ats;

    public void Assign(Stat stat)
    {
        
    }
    public static Stat operator +(Stat op1, Stat op2)
    {
        return new Stat
        {
            ad = op1.AD + op2.AD,
            hp = op1.Hp + op2.Hp,
        };
    }

}


public class Dice : MonoBehaviour
{
    public List<GameObject> eyes = new List<GameObject>();

    [SerializeField] private DiceData diceData;

    public Transform pos;

    public int eyeCount;
    public bool isDraging;

    public float Ats
    {
        get { return Ats; }
    }
    public DiceData DiceData
    {
        get
        {
            return diceData;
        }

        set
        {

        }
    }

    private void Start()
    {

    }
    /// <summary>
    /// АјАн
    /// </summary>
    /// <returns></returns>
    IEnumerator EAttack()
    {
        yield return null;
    }
}