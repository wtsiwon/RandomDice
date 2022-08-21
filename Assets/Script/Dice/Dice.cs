using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    private DiceCombine diceCombine;
    private const float RAYDISTANCE = 10f;
    private Vector3 dir = new Vector3(0, 0, 1f);
    private Vector3 rayOriginPos = new Vector3(0, 0, -1f);
    public Transform pos;


    public int eyeCount = 1;
    //드래그 중인가?
    public bool isDragging;
    //주사위 하고 부딪혔냐
    public bool isDice;

    public float Ats
    {
        get { return Ats; }
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

    private void Start()
    {
        diceCombine = GetComponent<DiceCombine>();
    }

    private void Update()
    {
        RayCasts();
    }

    private void RayCasts()
    {
        Debug.DrawRay(rayOriginPos, dir, new Color(1, 0, 0));
        RaycastHit ray;
        if(Physics.Raycast(rayOriginPos,dir,out ray,RAYDISTANCE))
        {
            if (ray.collider.CompareTag("Dice"))
            {
                isDice = true;
            }
        }
    }
    /// <summary>
    /// 공격
    /// </summary>
    /// <returns></returns>
    IEnumerator EAttack()
    {
        

        yield return null;
    }
}