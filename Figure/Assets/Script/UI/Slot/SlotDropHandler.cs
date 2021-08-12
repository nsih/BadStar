using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotDropHandler : MonoBehaviour,IDropHandler
{
    GameObject draged;

    public GameObject item
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
        if(!item)
        {
            SlotDragHandler.dragedSlot.transform.SetParent(transform);
            ExecuteEvents.ExecuteHierarchy<ISlotChange> (gameObject,null,(x,y) => x.SlotChange() );
        }
    }
}
