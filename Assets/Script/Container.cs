using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    private bool isFull => dice != null;

    /// <summary>
    /// 이 컨테이너에 Dice가 있고 드래그 중인 상태이고 그 주사위의 종류과 눈의 개수가 같으면
    /// </summary>
    public bool CanCombine => isFull && DiceManager.Instance.IsDraggingDice && 
    DiceManager.Instance.draggingDice.DiceData.diceType == dice.DiceData.diceType &&
    DiceManager.Instance.draggingDice.EyeCount == dice.EyeCount;
    

    //컨테이너에 있는 Dice정보
    public Dice dice;

    private void Start()
    {
        dice = GetComponentInChildren<Dice>();
    }
}
