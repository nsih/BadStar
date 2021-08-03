using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//대화 ui를 관리하는 매니저
public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject dialogueBar;
    [SerializeField] public string dialogueName;
    [SerializeField] Text dialogueTxt;
    public Text nameTxt;


    Dialogue[] dialogues;


    public bool isDialogue = false;
    public bool isNext = false;    //입력키 대기.
    bool isplayer;  //화자가 플레이어인가?

    int lineCount = 0;      //대화카운트
    int contextCount = 0;   //대사카운트


    void Update() 
    {
        //NextLint();
    }
    public void ShowDialogue(Dialogue[] p_dialogues)
    {
        isDialogue = true;

        dialogueTxt.text = "";
        
        dialogues = p_dialogues;

        StartCoroutine (TypeWriter());
    }

    public void ShutDialogue()  //초기화 종료
    {
        isDialogue =false;
        contextCount = 0;
        lineCount = 0;
        dialogues = null;
        isNext = false;

        SettingUI(false);

        Time.timeScale = 1;
    }

    void SettingUI(bool p_flag)
    {
        dialogueBar.SetActive(p_flag);
    }

    public void NextLint()
    {
        if(isDialogue)
        {
            if(isNext)
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    isNext = false;
                    dialogueTxt.text = "";

                    if(++contextCount < dialogues[lineCount].contexts.Length)
                    {
                        StartCoroutine (TypeWriter());
                    }

                    else
                    {
                        contextCount = 0; //전에 대사 쳤던(한사람이) 카운트 초기화
                        if(++lineCount < dialogues.Length) //왔다갔다 대화를 다 못했을때
                        {
                            StartCoroutine(TypeWriter());
                        }
                        else
                        {
                            ShutDialogue();
                        }
                    }
                }
            }
        }
    }

    IEnumerator TypeWriter() //출력코루틴
    {
        SettingUI(true);
        dialogueTxt.text = dialogues[lineCount].contexts[contextCount];
        dialogueName = dialogues[lineCount].name;
        
        isNext = true;
        yield return null;        
    }


    bool IdentifySpeaker()
    {
        if(isNext)
        {
            isplayer = true;
        }

        else
        {
            isplayer = false;
        }

        return isplayer;
    }
    /*
    IEnumerator Delay()
    {
        yield return new WaitForSeconds (0.5f);
    }
    */
}
