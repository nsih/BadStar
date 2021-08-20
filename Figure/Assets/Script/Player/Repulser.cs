using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repulser : MonoBehaviour
{
    public GameObject player;

    float decelerationSpeed;

    void Start() 
    {
        decelerationSpeed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        GuageControll();
    }

    void GuageControll()
    {
        player.GetComponent<PlayerInfo>().Gauge = player.GetComponent<PlayerInfo>().Gauge - decelerationSpeed;
        
        Debug.Log(decelerationSpeed);
        Debug.Log(player.GetComponent<PlayerInfo>().Gauge);
    }

    void BulletRemoval()
    {
        
    }
}
