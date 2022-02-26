using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //2秒後にReturnToTitleを呼び出す
        Invoke("ReturnToTitle", 2.0f);
    }

}
