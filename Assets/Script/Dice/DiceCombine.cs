using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = UnityEngine.Random;

public class DiceCombine : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    private Dice Dice;
    private RectTransform rtf;

    //현재 누르고 있는지
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
        rtf.position = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (Dice.isDragging == true)
        {
            if (Dice.isDice == true)
            {
                Instantiate(DiceManager.Instance.Combine(Dice, DiceManager.Instance.currentCollidDice));
            }
        }
    }
}
