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
            GameObject wave = Instantiate(mace, (transform.position + new Vector3(-0.5f,2f,-2f)), Quaternion.LookRotation(transform.forward));
            wave.GetComponent<Rigidbody>().velocity = transform.forward.normalized * maceSpeed;
            yield return new WaitForSeconds(2.0f);
        }
    }
}