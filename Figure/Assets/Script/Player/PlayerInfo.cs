using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//플레이어 정보
public class PlayerInfo : MonoBehaviour
{
    public GameObject onColliderObject;

    public int sup_SlotState;   //main
    public int sec_SlotState;   //sub
    
    public int atk;
    public int moveSpeed;

    public float Gauge;


    public bool isCanDialogue;   //대화시작 가능?
    public bool isDialogue;      //대화중?
    
    public bool isSlotChangable; //교체장소 접속

    void Start() 
    {
        Gauge = 100;

        sup_SlotState = 0;
        sec_SlotState = 0;

        moveSpeed = 5;

        isCanDialogue = false;
        isDialogue = false;
    }

    public void SupremeSlot()   //Attack
    {
        
    }




    /*
    *   상호작용 ui
    */

    public void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.gameObject.tag == "Npc")
        {
            isCanDialogue = true;
            
            onColliderObject = collider.gameObject;
            collider.transform.GetComponent<InteractionEvent>().GetDialogue();
        }

        if(collider.gameObject.tag == "ReplacePlace")
        {
            isSlotChangable = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Npc")
        {
            isCanDialogue = false;
        }

        if(collider.gameObject.tag == "ReplacePlace")
        {
            isSlotChangable = false;
        }

        else
        {
            onColliderObject = null;
        }
    }
}