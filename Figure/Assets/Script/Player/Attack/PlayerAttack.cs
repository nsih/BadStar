using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack: MonoBehaviour
{
    List<GameObject> items = new List<GameObject>();

    GameObject playerManager;
    GameObject player;
    GameObject muzzle;
    GameObject bulletRotation;
    
    public GameObject normalA;
    
    public int tempSlotState;

    public float attackRate;
    public float timerTime;
    bool isShootable;


    void Start()
    {
        playerManager = GameObject.Find("PlayerManager");
        player = GameObject.Find("Player");
        muzzle = GameObject.Find("Muzzle");
        bulletRotation = GameObject.Find("RrotatingBody");

        tempSlotState = player.GetComponent<PlayerInfo>().sup_SlotState;

        timerTime = 0;
        isShootable = true;

        InitPool();
        CheckRateTime();
    }

    void Update()
    {
        CheckSlotChange();  //슬롯 체크
        CheckRateTime();    //공격 딜레이 시간 체크
        FireDelay();        //딜레이 실행

        if (Input.GetMouseButtonDown(0) && isShootable == true)
        {
            ActivateProjectile();
        }
        /*
        Debug.Log(isShootable);
        Debug.Log(timerTime);
        */
    }

    public void CheckSlotChange()
    {
        if(tempSlotState != player.GetComponent<PlayerInfo>().sup_SlotState)
        {
            tempSlotState = player.GetComponent<PlayerInfo>().sup_SlotState;

            /*
            Debug.Log("aSlotState : " + player.GetComponent<PlayerInfo>().sup_SlotState);
            Debug.Log("tempSlotState : " + tempSlotState);
            */

            DisposePool();      //풀 삭제
            InitPool();         //풀 생성
        }
    }


    /*
    *   about rate of fire
    */

    public void CheckRateTime() ////supreme slot 값마다 다른 공격 연사속도.
    {
        if(player.GetComponent<PlayerInfo>().sup_SlotState == 0)
            attackRate = 0.2f;
    }
    void FireDelay()    //delay
    {
        if(timerTime < attackRate)
            timerTime += Time.deltaTime;

        else
        {
            isShootable = true;
            timerTime = 0;
        }

        //Debug.Log("as");
    }


    /*
    *   pool
    */

    public void InitPool()  //supreme slot 값마다 다른 공격 오브젝트 재고.
    {
        for(int i = 0; i < 15; i++)
        {
            if(player.GetComponent<PlayerInfo>().sup_SlotState == 0)
            {
                GameObject temp = Instantiate(normalA as GameObject);
                temp.gameObject.SetActive(false);

                items.Add(temp);
                items[i].transform.SetParent(playerManager.transform);
            }
            /*
            else if(player.GetComponent<PlayerInfo>().sup_SlotState == 1)
            else if(player.GetComponent<PlayerInfo>().sup_SlotState == 2)
            else if(player.GetComponent<PlayerInfo>().sup_SlotState == 3)
            */

            else    //보류
                return;
        }
    }

    public void ActivateProjectile()  //활성화
    {
        for(int i = 0; i <= items.Count ; i++)
        {
            int act = 0;

            foreach (var item in items)
            {
                if(item.activeSelf == true)
                    act ++;
            }

            if(act == items.Count)      //풀 부족. 되도록 이딴 버그 안나오게 설계
            {
                Debug.Log("pool error");
                break;
            }

            else if (items[i].activeSelf == false )
            {
                items[i].transform.position = muzzle.transform.position;
                items[i].transform.rotation = bulletRotation.transform.rotation;
                items[i].SetActive(true);     

                isShootable = false;
                break;
            }
        }
    }

    public void DisposePool() //change시 해제하기 위함
    {
        foreach(var item in items)
        {
            GameObject.Destroy(item);
        }
        
        items.Clear();
    }
}
