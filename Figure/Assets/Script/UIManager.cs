using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject buildUI;
    public GameObject dialogueBar;

    GameObject dialogueManager;
    GameObject player;


    void Awake() 
    {
        dialogueManager = GameObject.Find("DialogueManager");
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if(dialogueBar.activeSelf == false)
            SlotUIController();

        if(buildUI.activeSelf == false)
            InteractionUIController();
    }

    void SlotUIController() //슬롯을 바꾸기 위해
    {
        if( buildUI.activeSelf == false)
        {
            if( Input.GetKeyDown(KeyCode.Space) )
            {
                Time.timeScale = 0;
                buildUI.SetActive(true);
            }
        }

        else if (buildUI.activeSelf == true)
        {
            if( Input.GetKeyDown(KeyCode.Space) )
            {
                Time.timeScale = 1;
                buildUI.SetActive(false);
            }
                
        }
    }

    void InteractionUIController()  
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(dialogueBar.activeSelf == false && player.GetComponent<PlayerInfo>().isCanDialogue == true)
            {
                //Debug.Log("켬");

                Time.timeScale = 0;
                dialogueManager.GetComponent<DialogueManager>().
                ShowDialogue(player.GetComponent<PlayerInfo>().
                onColliderObject.GetComponent<InteractionEvent>().GetDialogue() );
            }

            else if(dialogueBar.activeSelf == true)
            {
                dialogueManager.GetComponent<DialogueManager>().NextLint();
            }
        }
    }
}