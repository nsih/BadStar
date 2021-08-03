using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//대화 데이터에서 정리된 리스트 중에 쓸 대화를 뽑게 관리하는 메니저

public class DialogueDataManager : MonoBehaviour
{
    public static DialogueDataManager instance;

    [SerializeField] string csv_FileName;

    Dictionary<int, Dialogue> dialogueDic = new Dictionary<int, Dialogue>();
    public static bool isFinish = false; //저장완료?


    void Awake() 
    {
        if(instance == null)
        {
            instance = this;
            DialogueParser theParser = GetComponent<DialogueParser>();
            Dialogue[] dialogues = theParser.Parse(csv_FileName);

            for(int i = 0 ; i < dialogues.Length ; i++)
            {
                dialogueDic.Add(i+1, dialogues[i]);
            }

            isFinish = true;
        }
    }


    public Dialogue[] GetDialogue(int _StartNum, int _EndNum)   //오브젝트에서 추출할 정보get
    {
        List<Dialogue> dialogueList = new List<Dialogue>();

        for(int i = 0; i <= _EndNum - _StartNum ; i++) //대사 수
        {
            dialogueList.Add(dialogueDic[_StartNum + i]);
        }

        return dialogueList.ToArray();
    }
}
