using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : Singleton<DiceManager>
{
    public List<DiceData> deck = new List<DiceData>();

    public List<Transform> dicePos = new List<Transform>();


    /// <summary>
    /// 주사위 합치는 함수
    /// </summary>
    /// <param name="dice1">지금 들고 있는</param>
    /// <param name="dice2">합치려고하는</param>
    /// <returns></returns>
    public Dice Combine(Dice dice1, Dice dice2)
    {
        if (dice1 == null || dice2 == null) return null;

        Dice dice = null;
        if (dice1.eyeCount == dice2.eyeCount
            && dice1.DiceData.diceType == dice2.DiceData.diceType)
        {

            
        }
        return null;
    }

    private EDiceType RandDice()
    {
        int rand = Random.Range(0, 5);

        EDiceType dice = deck[rand].diceType;
        return dice;
    }
}