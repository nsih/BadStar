using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//플레이어 정보
public class PlayerInfo : MonoBehaviour
{
    public static PlayerInfo playerInfo = null;


    void Awake() 
    {
        if(playerInfo == null) //인스턴스가 씬에 없으면
        {
            playerInfo = this;  //자신을 instance로 넣는다.
            DontDestroyOnLoad(gameObject);  //onload에서 삭제하지 않는다.
        }
        
        else
        {
            if(playerInfo != this)  //이미 하나 존재하면
                Destroy(this.gameObject); //awake된 자신을 삭제
        }
    }


    public int sup_SlotState;   //main
    public int sec_SlotState;   //sub
    
    public int atk;
    public int moveSpeed;

    public float Gauge;


    public bool isCanDialogue;   //대화시작 가능?
    public bool isDialogue;      //대화중?
    public bool isRepulser;     //방어 활성화중?
    
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



    
    /*
    *   상호작용 ui
    */
    /*

    public GameObject onColliderObject;


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
    */
}