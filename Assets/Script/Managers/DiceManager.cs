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

        if (dice1.eyeCount == dice2.eyeCount
            && dice1.DiceData.diceType == dice2.DiceData.diceType)
        {
            
        }
        return dice2;
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
    public Dice SpawnDice()
    {
        Dice dice = null;
        int randDice = Random.Range(0, deck.Count);
        dice.DiceData = deck[randDice];
        return Instantiate(dice);
    }
    /// <summary>
    /// ���� �߸��ȤФ�
    /// �����غ��� �����̳ʴ� EmptyObject��
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