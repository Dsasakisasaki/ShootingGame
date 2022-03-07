using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaceController : MonoBehaviour
{
   
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (
            other.gameObject.tag == "Player" ||
            other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
    

}