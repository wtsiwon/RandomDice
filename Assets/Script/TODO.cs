using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TODO
{
    public static void Hotfix()
    {
        //DiceManager.cs 65 line
        //Dice dice = null;                             dice is null
        //int randDice = Random.Range(0, deck.Count);   dice is null
        //dice.DiceData = deck[randDice];               dice is null, dice(null).DiceData <- ?
        //Instantiate(dice);
    }

    public static void Suggest()
    {
        // Container.cs
        // -    클래스 안에 Dice를 넣고 Container안에 Dice가 들어갈때에 있는지 없는지 확인할때도
        //      Container.Dice가 null인지 확인하여 확인
        // -    Container안에 위치정보를 같이 넣어서 추후에 활용할 수 있도록 함
    }

    static GameObject SpawnGO(string name) => new GameObject(name);
}
