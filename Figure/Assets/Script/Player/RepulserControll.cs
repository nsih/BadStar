using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepulserControll : MonoBehaviour
{
    public GameObject repulser;


    void Update()
    {
        Activate();
        Exac();
    }

    void Activate()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            if(this.GetComponent<PlayerInfo>().Gauge > 10)
            {
                repulser.SetActive(true);
            }

            else
            {
                //적절한 제스쳐
            }
        }
    }

    void Exac()
    {
        if(Input.GetKeyUp(KeyCode.Q) || this.GetComponent<PlayerInfo>().Gauge <= 0)
        {
            repulser.SetActive(false);
        }
    }
}
