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

    public Dice currentCollidDice;

    //���� ��� �ִ� ���̽�
    public Dice draggingDice;

    public Dice dice;

    public bool IsDraggingDice
    {
        get { return draggingDice != null; }
    }

    public Button diceSpawnBtn;

    private void Start()
    {
        //diceSpawnBtn.onClick.AddListener(() =>
        //{
        //    SpawnDice();
        //});
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

        if (dice1.EyeCount == dice2.EyeCount
            && dice1.DiceData.diceType == dice2.DiceData.diceType)
        {
            dice2 = SpawnDice();
        }
        return dice2;
    }

    /// <summary>
    /// �ֻ����� ��ȯ���ִ� �Լ�
    /// </summary>
    /// <param name="parent"></param>
    public Dice SpawnDice()
    {
        Dice dice = Instantiate(this.dice); 
        int randDice = Random.Range(0, deck.Count);
        dice.DiceData = deck[randDice];
        
        return dice;
    }
    /// <summary>
    /// ��ĥ�� �ִ� �ֻ����� �����ֱ�
    /// </summary>
    /// <returns></returns>
    public void SelectDicePos()
    {
        foreach(Transform pos in dicePos)
        {
            if(pos.GetComponent<Container>().CanCombine == false)
            {
            }
        }
        
    }
}