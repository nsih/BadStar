using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//기본 공격 탄환
public class BasicAttack : MonoBehaviour
{
    float speed;
    float time;

    void OnEnable()
    {
        time = 0;
    }

    void Start() 
    {
        speed = 20;
    }

    void Update()
    {
        OffTimer();
    }

    void FixedUpdate() 
    {
        Movement();
    }

    void OffTimer() 
    {
        time += Time.deltaTime;

        if(time > 2.0f)
        {
            this.gameObject.SetActive(false);
        }
    }

    void Movement()
    {
        this.transform.Translate(Vector2.up * speed * Time.deltaTime); ;
    }

    private void Hit() //적한테 맞으면 호출할거임..
    {
        this.gameObject.SetActive(false);
    }
}
