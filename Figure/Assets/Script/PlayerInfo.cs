using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//플레이어 정보
public class PlayerInfo : MonoBehaviour
{
    public GameObject onColliderObject;

    public int aSlotState;
    public int sSlotState;

    
    public int atk;
    public int moveSpeed;



    public float CGauge; 
    //Casimir Effect? //게이지는 적을 공격하거나 적 공격을 스칠때 채워진다


    public bool isCanDialogue;   //대화시작 가능?
    public bool isDialogue;      //대화중?

    void Start() 
    {
        aSlotState = 0;
        sSlotState = 0;

        moveSpeed = 5;

        isCanDialogue = false;
        isDialogue = false;
    }

    void Update() 
    {
        SpecialA(); //Select the func to use as an int
    }



    /*
    *   Attacl Slot
    */


    /*
    *   Special Slot
    */


    public void AttackS()   //Attack spell
    {

    }

    public void SpecialA()  //special Abillity
    {
        if(sSlotState == 0)
            InitS();

        else if(sSlotState == 1)
            Sslot_Brutal();

        else if(sSlotState == 2)
            InitS();

        else if(sSlotState == 3)
            InitS();

        else if(sSlotState == 4)
            InitS();
    }

    public void InitS()
    {
        moveSpeed = 5;
    }

    public void Sslot_Brutal()
    {
        moveSpeed = 10;
    }

    /////

    public void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.gameObject.tag == "Npc")
        {
            isCanDialogue = true;
            
            onColliderObject = collider.gameObject;
            collider.transform.GetComponent<InteractionEvent>().GetDialogue();
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Npc")
        {
            isCanDialogue = false;
        }

        else
        {
            onColliderObject = null;
        }
    }
}