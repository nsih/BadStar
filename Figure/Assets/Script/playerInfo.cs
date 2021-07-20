using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    GameObject Aslot;
    GameObject Sslot;

    public int AslotState;
    public int SslotState;

    
    public int atk;
    public int moveSpeed;

    void Start() 
    {
        AslotState = 0;
        SslotState = 0;
        moveSpeed = 5;

        Aslot = GameObject.Find("Aslot");
        Sslot = GameObject.Find("Sslot");
    }

    void Update() 
    {
        AslotInfoUpdate();
        SslotInfoUpdate();
    }
    
    public void SpecialA()
    {
        if(SslotState == 0)
            return;

        else if(SslotState == 1)
            BrutalS();

        else if(SslotState == 2)
            BrutalS();

        else if(SslotState == 3)
            BrutalS();

        else if(SslotState == 4)
            BrutalS();
    }

    public void InitS()
    {

    }
    public void BrutalS()
    {
        moveSpeed = 10;
    }

    public void AslotInfoUpdate()
    {
        if(Aslot.transform.childCount == 0)
            AslotState = 0;

        else if (Aslot.transform.childCount != 0 )
        {
            if( Aslot.transform.GetChild(0).name == "Brutal")
                AslotState = 1;

            else if(Aslot.transform.GetChild(0).name == "Spark")
                AslotState = 2;

            else if(Aslot.transform.GetChild(0).name == "Focus")
                AslotState = 3;

            else if(Aslot.transform.GetChild(0).name == "Distortion")
                AslotState = 4;
        }
    }

    public void SslotInfoUpdate()
    {
        if(Sslot.transform.childCount == 0)
            SslotState = 0;

        else if(Sslot.transform.childCount != 0)
        {
            if( Sslot.transform.GetChild(0).name == "Brutal")
                SslotState = 1;

            else if(Sslot.transform.GetChild(0).name == "Spark")
                SslotState = 2;

            else if(Sslot.transform.GetChild(0).name == "Focus")
                SslotState = 3;

            else if(Sslot.transform.GetChild(0).name == "Distortion")
                SslotState = 4;
        }
    }

    /*
    
    */
}
