using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//대화바 위치 조정.
public class BarPosition : MonoBehaviour
{
    GameObject player;
    GameObject dialogueManager;

    Vector2 playerBarPos;
    Vector2 npcBarPos;

    void Start() 
    {
        player  = GameObject.Find("Player");
        dialogueManager = GameObject.Find("DialogueManager");

        UiPosSet();
    }
    void Update() 
    {
        UiPosSet();
        BarMovement();
    }

    void UiPosSet()
    {
        playerBarPos = player.transform.position;
        playerBarPos.y = playerBarPos.y + 1.5f;
        
        npcBarPos = player.GetComponent<PlayerInteraction>().onColliderObject.transform.position;
        npcBarPos.y = npcBarPos.y + 1.5f;
    }

    void BarMovement()
    {
        if( dialogueManager.GetComponent<DialogueManager>().dialogueName == "simon")
        {
            this.transform.position = playerBarPos;
            //this.GetComponent<RectTransform>().anchoredPosition = playerBarPos;
        }
        else
        {
            this.transform.position = npcBarPos;
            //this.GetComponent<RectTransform>().anchoredPosition = npcBarPos;
        }

        //Debug.Log(playerBarPos);
        //Debug.Log(npcBarPos);
    }



}
