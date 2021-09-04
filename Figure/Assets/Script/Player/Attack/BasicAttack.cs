using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAttack : MonoBehaviour
{
    float time;

    void OnEnable()
    {
        time = 0;
    }

    void Update()
    {
        OffTimer();
    }

    void OffTimer() 
    {
        time += Time.deltaTime;

        if(time > 3.0f)
        {
            this.gameObject.SetActive(false);
        }
    }

    void Movement() 
    {
        //this.transform.Translate(new Vector2.up);

        //new Vector2 as;
    }
}
