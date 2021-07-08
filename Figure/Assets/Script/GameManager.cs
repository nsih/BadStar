using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject BuildUI;

    void Update()
    {
        BuildUIController();
    }

    void BuildUIController()
    {
        if( BuildUI.activeSelf == false)
        {
            if( Input.GetKeyDown(KeyCode.E) )
            {
                BuildUI.SetActive(true);
                Debug.Log("asd");
            }
                
        }

        else
        {
            if( Input.GetKeyDown(KeyCode.E) )
                BuildUI.SetActive(false);
        }
    }
}
