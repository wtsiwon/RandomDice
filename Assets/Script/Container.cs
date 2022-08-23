using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    private bool isFull => dice != null;

    /// <summary>
    /// �� �����̳ʿ� Dice�� �ְ� �巡�� ���� �����̰� �� �ֻ����� ������ ���� ������ ������
    /// </summary>
    public bool CanCombine => isFull && DiceManager.Instance.IsDraggingDice && 
    DiceManager.Instance.draggingDice.DiceData.diceType == dice.DiceData.diceType &&
    DiceManager.Instance.draggingDice.EyeCount == dice.EyeCount;
    

    //�����̳ʿ� �ִ� Dice����
    public Dice dice;

    private void Start()
    {
        dice = GetComponentInChildren<Dice>();
    }
}
