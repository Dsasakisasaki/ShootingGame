using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Stage1Controller : MonoBehaviour
{
    public PlayerController player;
    public LifePanel lifePanel;
    public GameObject killCount; 
    public void Update()
    {
        //ライフパネルを更新
        lifePanel.UpdateLife(player.Life());
        
        //プレイヤーのライフが０になったらゲームオーバー
        if (player.Life() <= 0)
        {
            //これ以降のUpdateは止める
            enabled = false;

            //2秒後にReturnToRestartを呼び出す
            Invoke("ReturnToRestart", 2.0f);
         
        }

        if (player.GetKillCount() == 20)
        {
            Invoke("MoveToStage2", 2.0f);
        }

    }

    void ReturnToRestart()
    {
        //Restartに切り替え
        SceneManager.LoadScene("Restart");
    }

    void MoveToStage2()
    {
        //stage2に切り替え
        SceneManager.LoadScene("Stage2");
    }
}
