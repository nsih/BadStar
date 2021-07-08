using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlotDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Vector2 defaultPosiiton;

    public void OnBeginDrag(PointerEventData eventData) 
    {
        defaultPosiiton = this.transform.position;
    }

    public void OnDrag(PointerEventData eventdata)  
    {
        transform.position = eventdata.position;
    }

    public void OnEndDrag (PointerEventData eventData)   
    {
        this.transform.position = defaultPosiiton;
    }

    public void OnDrop(PointerEventData eventData)
    {

    }
}