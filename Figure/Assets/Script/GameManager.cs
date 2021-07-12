using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject BuildUI;

    void Update()
    {
        SlotUIController();
    }

    void SlotUIController()
    {
        if( BuildUI.activeSelf == false)
        {
            if( Input.GetKeyDown(KeyCode.E) )
            {
                Time.timeScale = 0;
                BuildUI.SetActive(true);
            }
        }

        else
        {
            if( Input.GetKeyDown(KeyCode.E) )
            {
                Time.timeScale = 0;
                BuildUI.SetActive(false);
            }
                
        }
    }
}
