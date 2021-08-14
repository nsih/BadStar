//휠을 돌리면 Aslot을 비어있는 상태를 포함해 있는 슬롯의 순서대로 바꿔줌.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WheelSlot : MonoBehaviour
{    
    public GameObject aSlot;

    public GameObject subSlot0;
    public GameObject subSlot1;
    public GameObject subSlot2;
    public GameObject subSlot3;


    bool upWheel;

    RectTransform aSlotTransform;
    RectTransform transform0;
    RectTransform transform1;
    RectTransform transform2;
    RectTransform transform3;

    int tempSlotNo = 0;


    void Start() 
    {
        aSlotTransform = aSlot.GetComponent<RectTransform>();

        transform0 = subSlot0.GetComponent<RectTransform>();
        transform1 = subSlot1.GetComponent<RectTransform>();
        transform2 = subSlot2.GetComponent<RectTransform>();
        transform3 = subSlot3.GetComponent<RectTransform>();



        //Debug.Log(aSlot.GetComponent<RectTransform>().position);
    }

    void Update()
    {
        SlotNoChange();
        //Debug.Log(aSlot.GetComponent<RectTransform>().position);
        //Debug.Log(tempSlotNo);
    }

    void SlotNoChange()
    {
        if(Input.GetAxis("Mouse ScrollWheel")  > 0) //위로
        {
            upWheel = true;

            if(tempSlotNo == 4)
            {
                tempSlotNo = 0;
                ChangeChip();
            }

            else
            {
                tempSlotNo = tempSlotNo + 1;
                ChangeChip();
            }
                
        }

        else if(Input.GetAxis("Mouse ScrollWheel")  < 0) //아래로
        {
            upWheel = false;

            if(tempSlotNo == 0)
            {
                tempSlotNo = 4;
                ChangeChip();
            }
                
            else
            {
                tempSlotNo = tempSlotNo - 1;
                ChangeChip();
            }
                
        }
    }

    void EmptySlotNoControll()  //중간에 비어있을때는
    {
        if(upWheel == true) //위로
        {
            if(tempSlotNo == 4)
            {
                tempSlotNo = 0;
            }

            else
            {
                tempSlotNo = tempSlotNo + 1;
            }
                
        }

        else if(upWheel == false) //아래로
        {
            if(tempSlotNo == 0)
            {
                tempSlotNo = 4;
            }
                
            else
            {
                tempSlotNo = tempSlotNo - 1;
            }
                
        }
    }

    void ChangeChip()  //insert + return
    {
        if(aSlot.transform.childCount == 0)
        {
            InsertChip();
        }

        else
        {
            InsertChip();
            ReturnChip();
        }

    }
    
    void InsertChip() //휠 숫자보고 바꿀칩을 고름 aslot에 뭐가 있었으면 참조해야할거 바뀜
    {
        if(aSlot.transform.childCount == 0)
        {
            if(tempSlotNo == 1)
            {
                if(subSlot0.transform.childCount == 0)
                {
                    EmptySlotNoControll();
                    InsertChip();
                }

                else
                {
                    subSlot0.transform.GetChild(0).gameObject.transform.SetParent(aSlot.transform);
                    aSlot.transform.GetChild(0).GetComponent<RectTransform>().position = aSlotTransform.position;
                }
            }

            else if(tempSlotNo == 2)
            {
                if(subSlot1.transform.childCount == 0)
                {
                    EmptySlotNoControll();
                    InsertChip();
                }

                else
                {
                    subSlot1.transform.GetChild(0).gameObject.transform.SetParent(aSlot.transform);
                    aSlot.transform.GetChild(0).GetComponent<RectTransform>().position = aSlotTransform.position;
                }
            }

            else if(tempSlotNo == 3)
            {
                if(subSlot2.transform.childCount == 0)
                {
                    EmptySlotNoControll();
                    InsertChip();
                }

                else
                {
                    subSlot2.transform.GetChild(0).gameObject.transform.SetParent(aSlot.transform);
                    aSlot.transform.GetChild(0).GetComponent<RectTransform>().position = aSlotTransform.position;
                }
            }

            else if(tempSlotNo == 4)
            {
                if(subSlot3.transform.childCount == 0)
                {
                    EmptySlotNoControll();
                    InsertChip();
                }

                else
                {
                    subSlot3.transform.GetChild(0).gameObject.transform.SetParent(aSlot.transform);
                    aSlot.transform.GetChild(0).GetComponent<RectTransform>().position = aSlotTransform.position;
                }
            }
        }

        else
        {
            if(tempSlotNo == 1)
            {
                if(subSlot0.transform.childCount == 0)
                {
                    EmptySlotNoControll();
                    InsertChip();
                }

                else
                {
                    subSlot0.transform.GetChild(0).gameObject.transform.SetParent(aSlot.transform);
                    aSlot.transform.GetChild(1).GetComponent<RectTransform>().position = aSlotTransform.position;
                }
            }

            else if(tempSlotNo == 2)
            {
                if(subSlot1.transform.childCount == 0)
                {
                    EmptySlotNoControll();
                    InsertChip();
                }

                else
                {
                    subSlot1.transform.GetChild(0).gameObject.transform.SetParent(aSlot.transform);
                    aSlot.transform.GetChild(1).GetComponent<RectTransform>().position = aSlotTransform.position;
                }
            }

            else if(tempSlotNo == 3)
            {
                if(subSlot2.transform.childCount == 0)
                {
                    EmptySlotNoControll();
                    InsertChip();
                }

                else
                {
                    subSlot2.transform.GetChild(0).gameObject.transform.SetParent(aSlot.transform);
                    aSlot.transform.GetChild(1).GetComponent<RectTransform>().position = aSlotTransform.position;
                }
            }

            else if(tempSlotNo == 4)
            {
                if(subSlot3.transform.childCount == 0)
                {
                    EmptySlotNoControll();
                    InsertChip();
                }

                else
                {
                    subSlot3.transform.GetChild(0).gameObject.transform.SetParent(aSlot.transform);
                    aSlot.transform.GetChild(1).GetComponent<RectTransform>().position = aSlotTransform.position;
                }
            }
        }

        
    }
    
    void ReturnChip()    //aslot 에 있는걸 칩이름 보고 되돌림 
    {
        if (aSlot.transform.childCount != 0)
        {
            if( aSlot.transform.GetChild(0).name == "Brutal")
            {
                aSlot.transform.GetChild(0).gameObject.transform.SetParent(subSlot0.transform);
                subSlot0.transform.GetChild(0).GetComponent<RectTransform>().position = transform0.position;
            }
            else if(aSlot.transform.GetChild(0).name == "Spark")
            {
                aSlot.transform.GetChild(0).gameObject.transform.SetParent(subSlot1.transform);
                subSlot1.transform.GetChild(0).GetComponent<RectTransform>().position = transform1.position;
            }

            else if(aSlot.transform.GetChild(0).name == "Focus")
            {
                aSlot.transform.GetChild(0).gameObject.transform.SetParent(subSlot2.transform);
                subSlot2.transform.GetChild(0).GetComponent<RectTransform>().position = transform2.position;
            }

            else if(aSlot.transform.GetChild(0).name == "Distortion")
            {
                aSlot.transform.GetChild(0).gameObject.transform.SetParent(subSlot3.transform);
                subSlot3.transform.GetChild(0).GetComponent<RectTransform>().position = transform3.position;
            }
        }
    }
}