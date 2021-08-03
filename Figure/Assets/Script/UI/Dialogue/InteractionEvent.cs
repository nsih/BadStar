using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//오브젝트 마다 어떤 대화를 해야할지 정해주는 스크립트 (다른스크립트에 의해서 실행)
public class InteractionEvent : MonoBehaviour
{
    [SerializeField] DialogueEvent dialogue;

    public Dialogue[] GetDialogue() //대화데이터에서 꺼내온다.
    {
        dialogue.dialogues = DialogueDataManager.instance.GetDialogue((int)dialogue.line.x,(int)dialogue.line.y);

        return dialogue.dialogues;
    }
}
