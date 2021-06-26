using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public int moveSpeed;

    private void Start()
    {
        moveSpeed = 5;
    }

    void FixedUpdate()
    {
        PlayerMove();
    }
    void Update()
    {
    }

    void PlayerMove()
    {
        if (Input.GetKey(KeyCode.W))
            player.transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);

        if (Input.GetKey(KeyCode.A))
            player.transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);


        if (Input.GetKey(KeyCode.S))
            player.transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);


        if (Input.GetKey(KeyCode.D))
            player.transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
    }
}
