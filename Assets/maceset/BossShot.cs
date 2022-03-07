using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShot : MonoBehaviour
{
    //public GameObject player;
    public GameObject mace;
    public float maceSpeed = 20.0f;

    void Start()
    {
        //transform.LookAt(player.transform);
        StartCoroutine("MaceShot");
    }

    void Update()
    {
        //transform.LookAt(player.transform);
    }

    IEnumerator MaceShot()
    {
        while (true)
        {
            GameObject wave = Instantiate(mace, (transform.position + new Vector3(-0.5f,1.5f,-2.5f)), Quaternion.Euler(180,0,90));
            wave.GetComponent<Rigidbody>().velocity = transform.forward.normalized * maceSpeed;
            yield return new WaitForSeconds(3.0f);
        }
    }
}