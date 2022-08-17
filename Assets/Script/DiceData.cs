using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct AttackTypeInfo
{
    [Header("전이 공격")]
    public bool electro;
    [Header("무작위 공격")]
    public bool randAtk;
    [Header("맨앞 공격")]
    [Tooltip("기본적인 공격 방식")]
    public bool firstAtk;
}
//지금은 필요 없음 업데이트 할수 있으면 넣기
public struct ProportionInfo
{
    [Header("잃은 체력 비례")]
    public bool lostHp;
    [Header("남은 체력 비례")]
    public bool remainHp;
    [Header("최대 체력 비례")]
    public bool maxHp;
}
[CreateAssetMenu(fileName = "DiceData", menuName = "Datas/DiceData", order = 0)]
public class DiceData : ScriptableObject
{
    public Stat stat;
    public AttackTypeInfo atkTypeInfo;
    public int count;
    public bool isDraging;
}
