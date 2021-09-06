using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuageUi : MonoBehaviour
{
    GameObject player;

    void Awake() 
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        this.gameObject.GetComponent<Image>().fillAmount = player.GetComponent<PlayerInfo>().Gauge /100;
    }
}
