using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartController : MonoBehaviour
{
    void Start()
    {
        //1.5秒後にReturnToStage1を呼び出す
        Invoke("ReturnToStage1", 1.5f);
    }
    void ReturnToStage1()
    {
        SceneManager.LoadScene("Stage1");
    }
}
