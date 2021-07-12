using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class SlotDropHandler : MonoBehaviour,IDropHandler
{
    GameObject draged;

    public GameObject ability
    {
        get
        {
            if(transform.childCount > 0)
            {
                return transform.GetChild (0).gameObject;
            }
            return null;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if(!ability)
        {
            SlotDragHandler.dragedSlot.transform.SetParent(transform);
        }
    }
}
