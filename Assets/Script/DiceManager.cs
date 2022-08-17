using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : Singleton<DiceManager>
{
    public List<DiceData> deck = new List<DiceData>();

    public List<Transform> dicePos = new List<Transform>();

}
