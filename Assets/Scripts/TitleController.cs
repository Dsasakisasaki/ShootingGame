﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("ReadyScene");
    }

}
