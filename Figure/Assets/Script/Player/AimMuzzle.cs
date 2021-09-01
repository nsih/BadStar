using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimMuzzle : MonoBehaviour
{
    Vector2 _mousePos;
    Vector2 _playerPos;

    public GameObject player;

    public float rotateSpeed = -150;
    public float objectDegree = 0;  //오브젝트 회전
    public float rotateDegree;  //겨낭하는 곳

    bool isAim = false;
    float timer = 0;

    void Update()
    {
        AimTimer();

        if(isAim == true) 
            Aim();

        else
            Rotate();
    }

    public void AimTimer()
    {
        if(Input.GetMouseButtonDown(0))
        {
            isAim = true;
            timer = 5.0f;
        }

        if(isAim == true)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0)
        {
            isAim = false;
        }
    }

    public void Rotate()
    {
        transform.Rotate(new Vector3(0 , 0 , rotateSpeed * Time.deltaTime ));
    }

    public void Aim()
    {
        _mousePos = Input.mousePosition;
        _playerPos = this.gameObject.transform.position;

        Vector3 target = Camera.main.ScreenToWorldPoint(_mousePos);

        float dy = target.y - _playerPos.y;
        float dx = target.x - _playerPos.x;

        rotateDegree = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;

        this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, rotateDegree - 90);
    }

    /*
    public void AimInit(float _rotateDegree)
    {
        objectDegree = this.transform.rotation.z;

        for( ; objectDegree == _rotateDegree  ; objectDegree ++)
        {
            this.transform.eulerAngles = new Vector3 (0f, 0f, objectDegree);

            Debug.Log("as");
        }

        if(objectDegree <= 360)
        {
            objectDegree = objectDegree + 0.5f;
            
            Debug.Log(objectDegree);
        }

        else
        {
            objectDegree = 0;
        }

        */    /*
    }
    */
}
