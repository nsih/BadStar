using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepulserControll : MonoBehaviour
{
    public GameObject player;
    public GameObject repulser;



    void Awake() 
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        Activate();
        Exac();
    }

    void Activate()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(this.GetComponent<PlayerInfo>().Gauge > 10)
            {
                player.GetComponent<PlayerInfo>().isRepulser = true;
                repulser.SetActive(true);
            }

            else
            {
                //최소 게이지를 채우지 못하셨군요? 그렇다면 매우 유감이지만 쓸수 없습니다!
            }
        }
    }

    void Exac()
    {
        if(Input.GetKeyUp(KeyCode.Space) || this.GetComponent<PlayerInfo>().Gauge <= 0)
        {
            player.GetComponent<PlayerInfo>().isRepulser = false;
            repulser.SetActive(false);
        }
    }
}
