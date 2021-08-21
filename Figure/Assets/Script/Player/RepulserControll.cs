using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepulserControll : MonoBehaviour
{
    public GameObject repulser;

    float inputTime = 0f;
    float delayTime;


    bool isRepulser;

    void Start() 
    {
        delayTime = 0.5f;
    }
    void Update()
    {
        GetInput();
        Controller(isRepulser);
    }

    void GetInput()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            if(this.GetComponent<PlayerInfo>().Gauge > 10)
            {
                inputTime += Time.deltaTime;
            }
        }

        if (Input.GetKeyUp(KeyCode.Q) || this.GetComponent<PlayerInfo>().Gauge <= 0)
        {
            inputTime = 0;
            isRepulser = false;
        }

        if(inputTime >= delayTime)
        {
            isRepulser = true;
        }
    }

    void GetDelaytime()
    {

    }

    void Controller(bool flag)
    {
        if(isRepulser == flag)  
        {
            repulser.SetActive(flag);
        }

        Debug.Log(flag);
    }
}
