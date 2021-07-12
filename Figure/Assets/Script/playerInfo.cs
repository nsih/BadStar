using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    public int atk;
    public int moveSpeed;
    public int slotState;

    void Start() 
    {
        moveSpeed = 5;
        slotState = 0;
    }
}
