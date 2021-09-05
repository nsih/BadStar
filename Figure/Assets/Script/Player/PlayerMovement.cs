using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    GameObject player;
    
    void Awake()
    {
        player = GameObject.Find("Player");
    }

    void FixedUpdate()
    {
        MovementKeyInput();
    }

    void MovementKeyInput()
    {
        if (Input.GetKey(KeyCode.W))
            player.transform.Translate(Vector2.up * Time.deltaTime * player.GetComponent<PlayerInfo>().moveSpeed);

        if (Input.GetKey(KeyCode.A))
            player.transform.Translate(Vector2.left * Time.deltaTime * player.GetComponent<PlayerInfo>().moveSpeed);


        if (Input.GetKey(KeyCode.S))
            player.transform.Translate(Vector2.down * Time.deltaTime * player.GetComponent<PlayerInfo>().moveSpeed);


        if (Input.GetKey(KeyCode.D))
            player.transform.Translate(Vector2.right * Time.deltaTime * player.GetComponent<PlayerInfo>().moveSpeed);
    }

    
}
