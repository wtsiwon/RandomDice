using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCombine : MonoBehaviour
{

    private void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    private void Combine()
    {

    }
    public Dice Combine(Dice dice1, Dice dice2)
    {
        if (dice1 == null || dice2 == null) return null;
        
        Dice dice = null;
        if (dice1.DiceData.eyeCount == dice2.DiceData.eyeCount
            && dice1.DiceData.diceType == dice2.DiceData.diceType)
        {

        }
        return null;
    }


}
