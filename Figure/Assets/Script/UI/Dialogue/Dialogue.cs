using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Dialogue  //커스텀 클래서
{
    [Tooltip("캐릭터 이름")]
    public string name;

    [Tooltip("대사 내용")]
    public string[] contexts;

}


[System.Serializable]
public class DialogueEvent
{
    public string name; //event 이름
    public Vector2 line; //x부터 y 까지 대화를 추출해낸다.
    public Dialogue[] dialogues;


}
