﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    PlayerController pc;

    private void Start()
    {
        //弾丸が登場したらPlayerControllerを探しに行く
        pc = FindObjectOfType<PlayerController>();
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    { 
        if (other.gameObject.tag == "Enemy")
        {
            
            Destroy(gameObject);
            Destroy(other.gameObject);
            pc.killEnemy(1);
            Debug.Log(pc.GetKillCount()); 
        }

        if (other.gameObject.tag == "Boss")
        {
            Destroy(gameObject);
            pc.killBoss(1); 
        }
    }
}
