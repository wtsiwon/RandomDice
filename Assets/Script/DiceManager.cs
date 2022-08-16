using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : Singleton<DiceManager>
{
    public Dice[,] diceGrid = new Dice[5, 3];
    public List<DiceData> dices = new List<DiceData>();

    public List<int> posIndex = new List<int>();

}
