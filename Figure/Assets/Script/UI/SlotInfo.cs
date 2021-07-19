using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotInfo : MonoBehaviour, ISlotChange
{
    [SerializeField] Transform slots;
    [SerializeField] Text slotInfoText;


    public int slotInfo0;
    public int slotInfo1;

    void Start()
    {
        SlotChange();
    }

    public void SlotChange()
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        builder.Append (" - ");
        foreach (Transform slotTransform in slots)
        {
            GameObject item = slotTransform.GetComponent<SlotDropHandler>().item;
            if(item)
            {
                builder.Append (item.name);
                builder.Append (" - ");
            }
        }
        slotInfoText.text = builder.ToString();
    }
}


namespace UnityEngine.EventSystems {
    public interface ISlotChange : IEventSystemHandler
    {
         void SlotChange();
    }
}
