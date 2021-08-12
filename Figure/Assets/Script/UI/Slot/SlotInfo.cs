using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotInfo : MonoBehaviour, ISlotChange
{
    [SerializeField] Transform slots;
    [SerializeField] Text slotInfoText;


    GameObject player;
    GameObject aSlot;
    GameObject sSlot;

    void Start()
    {
        SlotChange();


        player = GameObject.Find("Player");
        aSlot = GameObject.Find("Aslot");
        sSlot = GameObject.Find("Sslot");
    }

    void Update() 
    {
        AslotInfoUpdate();
        SslotInfoUpdate();  //slotInfo를 playerInfo로
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



    public void AslotInfoUpdate()
    {
        if(aSlot.transform.childCount == 0)
            player.GetComponent<PlayerInfo>().aSlotState = 0;

        else if (aSlot.transform.childCount != 0 )
        {
            if( aSlot.transform.GetChild(0).name == "Brutal")
                player.GetComponent<PlayerInfo>().aSlotState = 1;

            else if(aSlot.transform.GetChild(0).name == "Spark")
                player.GetComponent<PlayerInfo>().aSlotState = 2;

            else if(aSlot.transform.GetChild(0).name == "Focus")
                player.GetComponent<PlayerInfo>().aSlotState = 3;

            else if(aSlot.transform.GetChild(0).name == "Distortion")
                player.GetComponent<PlayerInfo>().aSlotState = 4;
        }
    }

    public void SslotInfoUpdate()
    {
        if(sSlot.transform.childCount == 0)
            player.GetComponent<PlayerInfo>().sSlotState = 0;

        else if(sSlot.transform.childCount != 0)
        {
            if( sSlot.transform.GetChild(0).name == "Brutal")
                player.GetComponent<PlayerInfo>().sSlotState = 1;

            else if(sSlot.transform.GetChild(0).name == "Spark")
                player.GetComponent<PlayerInfo>().sSlotState = 2;

            else if(sSlot.transform.GetChild(0).name == "Focus")
                player.GetComponent<PlayerInfo>().sSlotState = 3;

            else if(sSlot.transform.GetChild(0).name == "Distortion")
                player.GetComponent<PlayerInfo>().sSlotState = 4;
        }
    }
}


namespace UnityEngine.EventSystems {
    public interface ISlotChange : IEventSystemHandler
    {
         void SlotChange();
    }
}
