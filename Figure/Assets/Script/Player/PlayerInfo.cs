using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//플레이어 정보
public class PlayerInfo : MonoBehaviour
{
    public GameObject onColliderObject;

    public int aSlotState;
    public int rSlotState;

    
    public int atk;
    public int moveSpeed;



    public float Gauge; 


    public bool isCanDialogue;   //대화시작 가능?
    public bool isDialogue;      //대화중?

    public bool isSlotChangable; //

    void Start() 
    {
        Gauge = 100;

        aSlotState = 0;
        rSlotState = 0;

        moveSpeed = 5;

        isCanDialogue = false;
        isDialogue = false;
    }

    void Update() 
    {
        RepulserSlot(); //Select the func to use as an int
    }



    /*
    *   Attacl Slot
    */


    /*
    *   Special Slot
    */
    public void AttackSlot()   //Attack spell
    {

    }

    public void RepulserSlot()  //special Abillity
    {
        if(rSlotState == 0)
            Default_R();

        else if(rSlotState == 1)
            Brutal_R();

        else if(rSlotState == 2)
            Default_R();

        else if(rSlotState == 3)
            Default_R();

        else if(rSlotState == 4)
            Default_R();
    }

    public void Default_R()
    {
        moveSpeed = 5;
    }

    public void Brutal_R()
    {
        moveSpeed = 10;
    }


    /*
    *척력장치 기동중
    */

    void RepulserM()
    {

    }



    /*
    *   대화-충돌처리
    */

    public void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.gameObject.tag == "Npc")
        {
            isCanDialogue = true;
            
            onColliderObject = collider.gameObject;
            collider.transform.GetComponent<InteractionEvent>().GetDialogue();
        }

    /*
        if(collider.gameobject.tag == "")
        {
            isSlotChangable = true;
        }
        */
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