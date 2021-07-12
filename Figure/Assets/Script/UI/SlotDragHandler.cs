using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlotDragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject dragedSlot;

    Vector2 defaultPosiiton;
    
    Transform startParant;

    public void OnBeginDrag(PointerEventData eventData) //drag start
    {
        dragedSlot = gameObject;
        defaultPosiiton = transform.position;

        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventdata)   // draging
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag (PointerEventData eventData)  //end drag 
    {
        dragedSlot = null;

        startParant = transform.parent; //이동한곳의 부모.

        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if(transform.parent == startParant)
        {
            transform.position = startParant.position;
        }
    }
}