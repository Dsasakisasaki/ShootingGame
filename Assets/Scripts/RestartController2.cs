using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartController2 : MonoBehaviour
{
    void Start()
    {
        //1.5秒後にReturnToStage2を呼び出す
        Invoke("ReturnToStage2", 1.5f);
    }
    void ReturnToStage2()
    {
        SceneManager.LoadScene("Stage2");
    }
}

