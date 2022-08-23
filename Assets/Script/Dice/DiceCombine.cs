using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = UnityEngine.Random;

public class DiceCombine : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private Dice Dice;
    private RectTransform rtf;


    //���� ������ �ִ���
    public int mouseCondition;

    private void Start()
    {
        Dice = GetComponent<Dice>();
        rtf = GetComponent<RectTransform>();
    }
    private void Update()
    {

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        rtf.anchoredPosition += eventData.delta;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (DiceManager.Instance.currentCollidDice)
        {
            if (Dice.isDice == true)
            {
                Instantiate(DiceManager.Instance.Combine(Dice, DiceManager.Instance.currentCollidDice));
            }
            else
            {
                Dice.transform.position = Dice.pos.position;
            }
        }
    }
}
