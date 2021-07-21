using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public int AslotState;
    public int SslotState;

    
    public int atk;
    public int moveSpeed;

    void Start() 
    {
        AslotState = 0;
        SslotState = 0;

        moveSpeed = 5;
    }

    void Update() 
    {
        SpecialA(); //Select the func to use as an int

        ///
        Debug.Log("Attack slotState : "+ AslotState);
        Debug.Log("Special slotState : "+ SslotState);
    }



    /*
    *   Attacl Slot
    */





    /*
    *   Special Slot
    */


    public void SpecialA()
    {
        if(SslotState == 0)
            InitS();

        else if(SslotState == 1)
            Sslot_Brutal();

        else if(SslotState == 2)
            InitS();

        else if(SslotState == 3)
            InitS();

        else if(SslotState == 4)
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
}