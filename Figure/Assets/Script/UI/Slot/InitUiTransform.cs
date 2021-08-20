//active상태에서 시작할때 transform을 받고 끄게 하기 위해서 만듬

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitUiTransform : MonoBehaviour
{
    void Awake() 
    {
        this.gameObject.SetActive(false);
    }
}
