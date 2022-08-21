using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceManager : Singleton<DiceManager>
{
    public List<DiceData> deck = new List<DiceData>();

    public List<Transform> dicePos = new List<Transform>();

    public List<int> diceUpGradeCost = new List<int>();

    private Color falseActiveColor = new Color();
    //현재 드래그 중인 주사위
    public Dice currentCollidDice;

    public Button diceSpawnBtn;

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
    public Dice Combine(Dice dice1, Dice dice2)
    {
        if (dice1 == null || dice2 == null) return null;

        if (dice1.eyeCount == dice2.eyeCount
            && dice1.DiceData.diceType == dice2.DiceData.diceType)
        {
            
        }
        return dice2;
    }

    /// <summary>
    /// 다이스 종류 뽑아줌
    /// </summary>
    /// <returns></returns>
    private EDiceType RandDiceType()
    {
        int rand = Random.Range(0, 5);

        EDiceType dice = deck[rand].diceType;
        return dice;
    }

    /// <summary>
    /// 주사위를 소환해주는 함수
    /// </summary>
    /// <param name="parent"></param>
    public Dice SpawnDice()
    {
        Dice dice = null;
        int randDice = Random.Range(0, deck.Count);
        dice.DiceData = deck[randDice];
        return Instantiate(dice);
    }
    /// <summary>
    /// 뭔가 잘못된ㅠㅠ
    /// 생각해보니 컨테이너는 EmptyObject다
    /// </summary>
    /// <returns></returns>
    public List<Transform> SelectDicePos()
    {
        foreach(Transform pos in dicePos)
        {
            if(pos.GetComponent<Container>().canCombine == false)
            {

            }
        }
        return dicePos;
    }
}