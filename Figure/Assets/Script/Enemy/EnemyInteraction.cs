
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteraction : MonoBehaviour
{
    GameObject enemyTest;

    public GameObject onColliderObject;





    public void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.gameObject.tag == "PlayerAttack")
        {
            this.GetComponent<EnemyInfo>().hp = this.GetComponent<EnemyInfo>().hp - 1;

            collider.gameObject.SetActive(false);
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        onColliderObject = null;
    }
}
