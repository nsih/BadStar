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
    //public GameObject 

    
    public int tempSlotState;


    void Start()
    {
        playerManager = GameObject.Find("PlayerManager");
        player = GameObject.Find("Player");
        muzzle = GameObject.Find("Muzzle");
        bulletRotation = GameObject.Find("RrotatingBody");

        tempSlotState = player.GetComponent<PlayerInfo>().sup_SlotState;

        InitPool();
    }

    // Update is called once per frame
    void Update()
    {
        CheckSlotChange();

        if (Input.GetMouseButtonDown(0))
        {
            ActivateProjectile();
        }
    }


    public void CheckSlotChange()
    {
        if(tempSlotState != player.GetComponent<PlayerInfo>().sup_SlotState)
        {
            tempSlotState = player.GetComponent<PlayerInfo>().sup_SlotState;


            Debug.Log("aSlotState : " + player.GetComponent<PlayerInfo>().sup_SlotState);
            Debug.Log("tempSlotState : " + tempSlotState);


            DisposePool();
            InitPool();
        }
    }

    public void InitPool()
    {
        for(int i = 0; i < 30; i++)
        {
            if(player.GetComponent<PlayerInfo>().sup_SlotState == 0)
            {
                GameObject temp = Instantiate(normalA as GameObject);
                temp.gameObject.SetActive(false);

                items.Add(temp);
                items[i].transform.SetParent(playerManager.transform);


            }

            else
                return;
        }
    }

    public void ActivateProjectile()  //플레이어 투사체 발사.
    {
        for(int i = 0; i <= items.Count ; i++)
        {
            int act = 0;

            foreach (var item in items)
            {
                if(item.activeSelf == true)
                    act ++;
            }

            if(act == items.Count)
            {
                Debug.Log("pool error");
                break;;
            }

            else if (items[i].activeSelf == false )
            {
                items[i].transform.position = muzzle.transform.position;
                items[i].transform.rotation = bulletRotation.transform.rotation;
                items[i].SetActive(true);     

                break;
            }
        }
    }

    public void DisposePool() //해당 오브젝트 풀 해제.
    {
        foreach(var item in items)
        {
            GameObject.Destroy(item);
        }
        
        items.Clear();
    }
}
