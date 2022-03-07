
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class OnCollisionEnterSample : MonoBehaviour
{
    public int count=5;

    
    //OnCollisionEnter()
    private void OnCollisionEnter(Collision collision)
    {
        //Bossが衝突したオブジェクトのタグがBulletだった場合
        if (collision.gameObject.tag == "Bullet")
        {
            //カウントが減っていく
            count--;
            Debug.Log(count);
            
        }
        //カウントが０になったらオブジェクトデストロイ
        if(count == 0)
        {
            Destroy(gameObject);
        }
        
    }

    }

