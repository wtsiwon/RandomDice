using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;


[Serializable]
public struct Stat
{
    public Action OnDie;
    public float HP
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
        hp = stat.HP;
        ad = stat.AD;
        ats = stat.Ats;
    }
    public static Stat operator +(Stat op1, Stat op2)
    {
        return new Stat
        {
            ad = op1.AD + op2.AD,
            hp = op1.HP + op2.HP,
            ats = op1.Ats + op2.Ats
        };
    }

}


public class Dice : MonoBehaviour
{

    public List<GameObject> eyes = new List<GameObject>();

    [SerializeField] 
    private DiceData diceData;

    private DiceActivity diceActivity;
    

    private Image img;
    
    //private const int MAXEYECOUNT = 7;

    public Transform pos;

    private int eyeCount = 1;

    private bool isdragging;
    //드래그 중인가?
    public bool isDragging
    {
        get => isdragging;
        set
        {
            isdragging = value;
        }
    }

    public int EyeCount
    {
        get { return eyeCount; }
        set
        {
            eyes[eyeCount - 1].SetActive(false);
            eyeCount = value;
            eyes[eyeCount - 1].SetActive(true);
        }
    }
    public float Ats
    {
        get { return diceData.stat.Ats; }
        set { Ats = value; }
    }

    public DiceData DiceData
    {
        get => diceData;
        set
        {
            diceData = value;

        }
    }
    /// <summary>
    /// DiceType에 따라 색을 바꿔주는 함수
    /// </summary>
    private void SetDiceColor(EDiceType diceType)
    {
        switch (diceData.diceType)
        {
            case EDiceType.Fire:
                
                break;
        }
    }

    private void Start()
    {
        diceActivity = GetComponent<DiceActivity>();
    }

    private void Update()
    {
        
    }

    /// <summary>
    /// 공격
    /// </summary>
    /// <returns></returns>
    private IEnumerator EAttack()
    {
        while (true)
        {
            
        }
        yield return StartCoroutine(EAttack());
    }

    private void Attack()
    {

    }
}