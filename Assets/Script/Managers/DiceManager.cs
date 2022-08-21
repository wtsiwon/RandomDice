using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceManager : Singleton<DiceManager>
{
    public List<DiceData> deck = new List<DiceData>();

    public List<List<Transform>> dicePos = new List<List<Transform>>();

    public List<int> diceUpGradeCost = new List<int>();
    //���� �巡�� ���� �ֻ���
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
    /// �ֻ��� ��ġ�� �Լ�
    /// </summary>
    /// <param name="dice1">���� ��� �ִ�</param>
    /// <param name="dice2">��ġ�����ϴ�</param>
    /// <returns></returns>
    public Dice Combine(Dice dice1, Dice dice2)
    {
        if (dice1 == null || dice2 == null) return null;

        Dice dice = null;
        if (dice1.eyeCount == dice2.eyeCount
            && dice1.DiceData.diceType == dice2.DiceData.diceType)
        {
            RandDiceType();

        }
        return dice;
    }
    /// <summary>
    /// ���̽� ���� �̾���
    /// </summary>
    /// <returns></returns>
    private EDiceType RandDiceType()
    {
        int rand = Random.Range(0, 5);

        EDiceType dice = deck[rand].diceType;
        return dice;
    }

    /// <summary>
    /// �ֻ����� ��ȯ���ִ� �Լ�
    /// </summary>
    /// <param name="parent"></param>
    public void SpawnDice()
    {
        Dice dice = null;
        int randDice = Random.Range(0, deck.Count);
        dice.DiceData = deck[randDice];
        Instantiate(dice);
    }

    public void SelectDicePos()
    {
        
    }
}