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
        if(dialogueCanvas.activeSelf == false)
            SlotUIController();

        if(slotCanvas.activeSelf == false)
            InteractionUIController();
    }

    void SlotUIController() //슬롯을 바꾸기 위해
    {
        if( slotCanvas.activeSelf == false)
        {
            if( Input.GetKeyDown(KeyCode.Space) )
            {
                Time.timeScale = 0;
                slotCanvas.SetActive(true);
            }
        }

        else if (slotCanvas.activeSelf == true)
        {
            if( Input.GetKeyDown(KeyCode.Space) )
            {
                Time.timeScale = 1;
                slotCanvas.SetActive(false);
            }
                
        }
    }

    void InteractionUIController()  
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(dialogueCanvas.activeSelf == false && player.GetComponent<PlayerInfo>().isCanDialogue == true)
            {
                //Debug.Log("켬");

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
}