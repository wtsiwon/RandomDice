using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct AttackTypeInfo
{
    [Header("���� ����")]
    public bool electro;
    [Header("������ ����")]
    public bool randAtk;
    [Header("�Ǿ� ����")]
    [Tooltip("�⺻���� ���� ���")]
    public bool firstAtk;
}
//������ �ʿ� ���� ������Ʈ �Ҽ� ������ �ֱ�
public struct ProportionInfo
{
    [Header("���� ü�� ���")]
    public bool lostHp;
    [Header("���� ü�� ���")]
    public bool remainHp;
    [Header("�ִ� ü�� ���")]
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
