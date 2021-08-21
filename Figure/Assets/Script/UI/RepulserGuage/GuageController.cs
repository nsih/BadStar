using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuageController : MonoBehaviour
{
    public GameObject player;

    public Slider slider;

    void Update()
    {
        this.slider.value = player.GetComponent<PlayerInfo>().Gauge / 100;
    }
}