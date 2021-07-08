using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public Button NewgameB;
    public Button LoadB;
    public Button OptionB;
    public Button ExitB;
    
    void Start() 
    {
        NewgameB.onClick.AddListener(OnClickNewGame);
        LoadB.onClick.AddListener(OnClickLoad);
        OptionB.onClick.AddListener(OnClickOption);
        ExitB.onClick.AddListener(OnClickExit);
    }

    void OnClickNewGame()
    {
        SceneManager.LoadScene("StartGame");
    }

    void OnClickLoad()
    {
        Debug.Log("L");
    }

    void OnClickOption()
    {
        Debug.Log("O");
    }

    void OnClickExit()
    {
        Debug.Log("E");
    }
}
