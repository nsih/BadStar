using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//대화 데이터 파싱
public class DialogueParser : MonoBehaviour
{
    public Dialogue[] Parse(string _CSVFileName)
    {
        List<Dialogue> dialogueList = new List<Dialogue>(); //대사 리스트 생성
        TextAsset csvData = Resources.Load<TextAsset>(_CSVFileName); //csv파일 로드

        string[] data = csvData.text.Split(new char[] {'\n'}); //줄마다 바꿈

        for(int i = 1 ; i < data.Length ;  ) //첫줄 띄우고
        {
            string[] row = data[i].Split(new char[] {','} ); //,로 나눔

            Dialogue dialogue = new Dialogue(); //대사 list generate

            dialogue.name = row[1]; //이름

            List<string> contextList = new List<string>();  //대사 리스트 생성

            do
            {
                contextList.Add(row[2]);                //대사 리스트에 데이터 추가
                if(++i < data.Length)
                {
                    row = data[i].Split(new char[] {','});
                }
                    
                else
                    break;

            } while(row[0].ToString() == "");            //공백이면 반복 (다음대사 만)

            dialogue.contexts = contextList.ToArray();  //배열에 리스트 넣고
            dialogueList.Add(dialogue);                 //리스트에 다이얼로그 추가

        }

        return dialogueList.ToArray();                  //배열로 반환
    }
}
