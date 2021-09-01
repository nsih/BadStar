//슬롯 오브젝트 자식을 보고 플레이어의 상태 변경.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotInfo : MonoBehaviour
{
    [SerializeField] Transform slots;


    GameObject player;
    GameObject aSlot;
    GameObject sSlot;

    void Start()
    {
        player = GameObject.Find("Player");
        aSlot = GameObject.Find("UiRoot").transform.Find("SlotCanvas").transform.Find("Panel").transform.Find("MainPanel").transform.Find("Aslot").gameObject;
        sSlot = GameObject.Find("UiRoot").transform.Find("SlotCanvas").transform.Find("Panel").transform.Find("MainPanel").transform.Find("Sslot").gameObject;
    }

    void Update() 
    {
        AslotInfoUpdate();
        SslotInfoUpdate();  //slotInfo를 playerInfo로
    }



    public void AslotInfoUpdate()
    {
        if(aSlot.transform.childCount == 0)
            player.GetComponent<PlayerInfo>().sup_SlotState = 0;

        else if (aSlot.transform.childCount != 0 )
        {
            if( aSlot.transform.GetChild(0).name == "Brutal")
                player.GetComponent<PlayerInfo>().sup_SlotState = 1;

            else if(aSlot.transform.GetChild(0).name == "Spark")
                player.GetComponent<PlayerInfo>().sup_SlotState = 2;

            else if(aSlot.transform.GetChild(0).name == "Focus")
                player.GetComponent<PlayerInfo>().sup_SlotState = 3;

            else if(aSlot.transform.GetChild(0).name == "Distortion")
                player.GetComponent<PlayerInfo>().sup_SlotState = 4;
        }
    }

    public void SslotInfoUpdate()
    {
        if(sSlot.transform.childCount == 0)
            player.GetComponent<PlayerInfo>().sec_SlotState = 0;

        else if(sSlot.transform.childCount != 0)
        {
            if( sSlot.transform.GetChild(0).name == "Brutal")
                player.GetComponent<PlayerInfo>().sec_SlotState = 1;

            else if(sSlot.transform.GetChild(0).name == "Spark")
                player.GetComponent<PlayerInfo>().sec_SlotState = 2;

            else if(sSlot.transform.GetChild(0).name == "Focus")
                player.GetComponent<PlayerInfo>().sec_SlotState = 3;

            else if(sSlot.transform.GetChild(0).name == "Distortion")
                player.GetComponent<PlayerInfo>().sec_SlotState = 4;
        }
    }
}


namespace UnityEngine.EventSystems {
    public interface ISlotChange : IEventSystemHandler
    {
         void SlotChange();
    }
}
