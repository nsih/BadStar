using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryFunc : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        if(player.GetComponent<PlayerInfo>().sec_SlotState == 0)
            Default();
       
        else if(player.GetComponent<PlayerInfo>().sec_SlotState == 1)
            Brutal();

        else if(player.GetComponent<PlayerInfo>().sec_SlotState == 2)
            Default();

        else if(player.GetComponent<PlayerInfo>().sec_SlotState == 3)
            Default();

        else if(player.GetComponent<PlayerInfo>().sec_SlotState == 4)
            Default();
    }


    void Default()
    {
        player.GetComponent<PlayerInfo>().moveSpeed = 5;
    }

    void Brutal()
    {
        player.GetComponent<PlayerInfo>().moveSpeed = 10;
    }

    void Focus() 
    {

    }

    
}
