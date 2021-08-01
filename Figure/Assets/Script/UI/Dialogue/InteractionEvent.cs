using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//대화 NPC 마다 넣는 스크립트
public class InteractionEvent : MonoBehaviour
{
    [SerializeField] DialogueEvent dialogue;

    public Dialogue[] GetDialogue()
    {
        dialogue.dialogues = DIalogueManager.instance.GetDialogue((int)dialogue.line.x,(int)dialogue.line.y);

        return dialogue.dialogues;
    }
}
