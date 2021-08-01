using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public int aSlotState;
    public int sSlotState;

    
    public int atk;
    public int moveSpeed;

    public int isCanDialogue;

    void Start() 
    {
        aSlotState = 0;
        sSlotState = 0;

        moveSpeed = 5;
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

    void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.gameObject.tag == "Npc")
            isCanDialogue = 1;
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Npc")
            isCanDialogue = 0;
    }
}