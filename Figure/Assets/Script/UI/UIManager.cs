using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject slotCanvas;
    public GameObject dialogueCanvas;


    GameObject dialogueManager;
    GameObject player;
    


    void Awake() 
    {
        dialogueManager = GameObject.Find("DialogueManager");
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            InteractionUIController();
        }
    }



    void InteractionUIController()
    {
        SlotUIController();
        DialogueUIController();
    }




    void SlotUIController() //슬롯을 바꾸기 위해
    {
        if( slotCanvas.activeSelf == false && player.GetComponent<PlayerInfo>().isSlotChangable == true)
        {
            Time.timeScale = 0;
            slotCanvas.SetActive(true);
        }

        else if (slotCanvas.activeSelf == true)
        {
            Time.timeScale = 1;
            slotCanvas.SetActive(false);
                
        }
    }

    void DialogueUIController()  
    {
        if(dialogueCanvas.activeSelf == false && player.GetComponent<PlayerInfo>().isCanDialogue == true)
        {
            Time.timeScale = 0;

            dialogueManager.GetComponent<DialogueManager>().
            ShowDialogue(player.GetComponent<PlayerInfo>().
            onColliderObject.GetComponent<InteractionEvent>().GetDialogue() );
        }

        else if(dialogueCanvas.activeSelf == true)
        {
            dialogueManager.GetComponent<DialogueManager>().NextLint();
        }
    }
}