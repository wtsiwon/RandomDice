using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = UnityEngine.Random;

public class DiceActivity : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private Dice Dice;
    private DiceRay DiceRay;
    private RectTransform rtf;
    private DiceManager diceManager;
    private Container container;

    //현재 누르고 있는지
    public int mouseCondition;

    private void Start()
    {
        GetComponents();

        diceManager = DiceManager.Instance;
    }
    private void Update()
    {

    }
    private void GetComponents()
    {
        Dice = GetComponent<Dice>();
        DiceRay = GetComponent<DiceRay>();
        rtf = GetComponent<RectTransform>();
        container = GetComponentInParent<Container>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Dice.isDragging = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rtf.anchoredPosition += eventData.delta;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (diceManager.currentCollidDice == null)
        {
            ReSetPos();
            return;
        }


        diceManager.Combine(diceManager.draggingDice, diceManager.currentCollidDice);
        Dice.isDragging = false;
    }
    /// <summary>
    /// 땟을 때 합치지 못한다면 다시 원래 위치로
    /// </summary>
    private void ReSetPos()
    {
        transform.SetParent(container.transform);
    }
}