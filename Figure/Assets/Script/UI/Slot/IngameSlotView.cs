//5시 방향의 ui에 현재 슬롯정보를 보여주기위한 스크립트

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngameSlotView : MonoBehaviour
{
    public GameObject slot0;
    public GameObject slot1;

    public GameObject aSlot;
    public GameObject sSlot;


    void Update()
    {
        CopyAslotImage();
        CopySslotImage();
    }

    void CopyAslotImage()
    {
        if(aSlot.transform.childCount == 0)
        {
            slot0.GetComponent<Image>().sprite = null;
        }

        else
        {
            slot0.GetComponent<Image>().sprite = aSlot.transform.GetChild(0).GetComponent<Image>().sprite;
        }
    }

    void CopySslotImage()
    {
        if(sSlot.transform.childCount == 0)
        {
            slot1.GetComponent<Image>().sprite = null;
        }

        else
        {
            slot1.GetComponent<Image>().sprite = sSlot.transform.GetChild(0).GetComponent<Image>().sprite;
        }
    }
}
