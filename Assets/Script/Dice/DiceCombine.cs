using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = UnityEngine.Random;

public class DiceCombine : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private Dice Dice;
    private DiceRay DiceRay;
    private RectTransform rtf;


    //현재 누르고 있는지
    public int mouseCondition;

    private void Start()
    {
        Dice = GetComponent<Dice>();
        DiceRay = GetComponent<DiceRay>();
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
            if (DiceRay.isDice == true)
            {
                
            }
            else
            {
                Dice.transform.position = Dice.pos.position;
            }
        }
    }
}
