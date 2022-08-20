using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = UnityEngine.Random;

public class DiceCombine : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IDragHandler
{
    private Dice Dice;

    private void Start()
    {
        Dice = GetComponent<Dice>();
    }
    private void Update()
    {
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnPointerUp(PointerEventData eventData)
    {
    }

    public void OnDrag(PointerEventData eventData)
    {
    }
}
