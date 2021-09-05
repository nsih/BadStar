using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject onColliderObject;


    public void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.gameObject.tag == "Npc")
        {
            this.GetComponent<PlayerInfo>().isCanDialogue = true;
            
            onColliderObject = collider.gameObject;
            collider.transform.GetComponent<InteractionEvent>().GetDialogue();
        }

        if(collider.gameObject.tag == "ReplacePlace")
        {
            this.GetComponent<PlayerInfo>().isSlotChangable = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Npc")
        {
            this.GetComponent<PlayerInfo>().isCanDialogue = false;
        }

        if(collider.gameObject.tag == "ReplacePlace")
        {
            this.GetComponent<PlayerInfo>().isSlotChangable = false;
        }

        else
        {
            onColliderObject = null;
        }
    }
}
