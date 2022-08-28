using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceManager : Singleton<DiceManager>
{
    public List<DiceData> deck = new List<DiceData>();

    public List<GameObject> dicePos = new List<GameObject>();

    public List<GameObject> selectDicePos = new List<GameObject>();

    public List<int> diceUpGradeCost = new List<int>()
    {
        100,200,400,700
    };

    private Color falseActiveColor = new Color();

    public Dice currentCollidDice;

    //현재 들고 있는 다이스
    public Dice draggingDice;

    //기본 다이스
    public Dice dice;

    public bool IsDraggingDice
    {
        get { return draggingDice != null; }
    }

    public Button diceSpawnBtn;

    public Canvas canvas;

    private void Start()
    {
        diceSpawnBtn.onClick.AddListener(() =>
        {
            SpawnDice();
        });
    }

    /// <summary>
    /// 주사위 합치는 함수
    /// </summary>
    /// <param name="dice1">지금 들고 있는</param>
    /// <param name="dice2">합치려고하는</param>
    /// <returns></returns>
    public void DiceCombine(Dice dice1, Dice dice2)
    {
        if (dice1 == null || dice2 == null)
        {
            return;
        }

        if (dice1.EyeCount == dice2.EyeCount
            && dice1.DiceData.diceType == dice2.DiceData.diceType)
        {
            dice2 = RandomDiceSelect(dice2);
        }
    }


    /// <summary>
    /// 랜덤 주사위 선택
    /// </summary>
    /// <returns></returns>
    private Dice RandomDiceSelect(Dice dice)
    {
        int randDice = Random.Range(0, deck.Count);

        dice.DiceData = deck[randDice];
        return dice;
    }

    /// <summary>
    /// 주사위를 소환해주는 함수
    /// </summary>
    /// <param name="parent"></param>
    public void SpawnDice()
    {
        SelectCanCombineDice();

        int randDice = Random.Range(0, deck.Count);
        int randPos = Random.Range(0, selectDicePos.Count);

        Dice dice = Instantiate(this.dice);
        dice.DiceData = deck[randDice];

        Instantiate(dice, selectDicePos[randPos].transform);
    }


    /// <summary>
    /// 합칠수 있는 주사위만 보여주기
    /// </summary>
    /// <returns></returns>
    public void SelectCanCombineDice()
    {
        foreach (GameObject pos in dicePos)
        {
            if (pos.GetComponent<Container>().CanCombine == false)
            {
                if (IsDraggingDice == true)
                {
                    pos.GetComponent<Image>().color = falseActiveColor;
                }

                selectDicePos.Add(pos);
            }
        }
    }
}