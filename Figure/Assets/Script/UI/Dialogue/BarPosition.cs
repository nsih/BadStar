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

    void Awake() 
    {
        player  = GameObject.Find("Player");
        dialogueManager = GameObject.Find("DialogueManager");

        UiPosSet();
    }
    void Update() 
    {
        BarMovement();
    }

    void UiPosSet()
    {
        playerBarPos = player.transform.position;
        playerBarPos.y = playerBarPos.y + 2.0f;
        
        npcBarPos = player.GetComponent<PlayerInfo>().onColliderObject.transform.position;
        npcBarPos.y = npcBarPos.y + 2.0f;
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

        Debug.Log(playerBarPos);
        Debug.Log(npcBarPos);
    }



}
