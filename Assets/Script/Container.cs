using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    public int index;
    private bool isFull => dice != null;

    /// <summary>
    /// �� �����̳ʿ� Dice�� �ְ� �巡�� ���� �����̰� �� �ֻ����� ������ ���� ������ ������
    /// </summary>
    public bool CanCombine => isFull && DiceManager.Instance.IsDraggingDice && 
    DiceManager.Instance.draggingDice.DiceData.diceType == dice.DiceData.diceType &&
    DiceManager.Instance.draggingDice.EyeCount == dice.EyeCount;


    //�����̳ʿ� �ִ� Dice����
    private Dice dice;
    public Dice Dice
    {
        get
        {
            return dice;
        }
        set
        {
            dice = value;
        }
    }

    private void Start()
    {

    }
}
