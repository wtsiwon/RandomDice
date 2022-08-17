using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : Singleton<DiceManager>
{
    public Dice[,] diceGrid = new Dice[5, 3];

    public List<DiceData> deck = new List<DiceData>();

    public List<int> posIndex = new List<int>()
    {
        0,1,2,3,4,5,6,7,8,9,10,11,12,13,14
    };


}
