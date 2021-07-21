using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotInfo : MonoBehaviour, ISlotChange
{
    [SerializeField] Transform slots;
    [SerializeField] Text slotInfoText;


    GameObject Player;
    GameObject Aslot;
    GameObject Sslot;

    public int slotInfo0;
    public int slotInfo1;

    void Start()
    {
        SlotChange();


        Player = GameObject.Find("Player");
        Aslot = GameObject.Find("Aslot");
        Sslot = GameObject.Find("Sslot");
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
        if(Aslot.transform.childCount == 0)
            Player.GetComponent<PlayerInfo>().AslotState = 0;

        else if (Aslot.transform.childCount != 0 )
        {
            if( Aslot.transform.GetChild(0).name == "Brutal")
                Player.GetComponent<PlayerInfo>().AslotState = 1;

            else if(Aslot.transform.GetChild(0).name == "Spark")
                Player.GetComponent<PlayerInfo>().AslotState = 2;

            else if(Aslot.transform.GetChild(0).name == "Focus")
                Player.GetComponent<PlayerInfo>().AslotState = 3;

            else if(Aslot.transform.GetChild(0).name == "Distortion")
                Player.GetComponent<PlayerInfo>().AslotState = 4;
        }
    }

    public void SslotInfoUpdate()
    {
        if(Sslot.transform.childCount == 0)
            Player.GetComponent<PlayerInfo>().SslotState = 0;

        else if(Sslot.transform.childCount != 0)
        {
            if( Sslot.transform.GetChild(0).name == "Brutal")
                Player.GetComponent<PlayerInfo>().SslotState = 1;

            else if(Sslot.transform.GetChild(0).name == "Spark")
                Player.GetComponent<PlayerInfo>().SslotState = 2;

            else if(Sslot.transform.GetChild(0).name == "Focus")
                Player.GetComponent<PlayerInfo>().SslotState = 3;

            else if(Sslot.transform.GetChild(0).name == "Distortion")
                Player.GetComponent<PlayerInfo>().SslotState = 4;
        }
    }
}


namespace UnityEngine.EventSystems {
    public interface ISlotChange : IEventSystemHandler
    {
         void SlotChange();
    }
}
