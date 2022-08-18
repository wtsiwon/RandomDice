using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = UnityEngine.Random;

public class DiceCombine : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IDragHandler
{

    private void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
   

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
