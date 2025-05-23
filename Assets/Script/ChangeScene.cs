using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject boxwindow;

    public void ChangeSceneBtn()
    {
        switch (this.gameObject.name)
        {
            case "retryBtn":
                SceneManager.LoadScene("InGame");
                Debug.Log("게임으로!");
                break;
            case "outBtn":
                SceneManager.LoadScene("Mainmenu");
                Debug.Log("메인메뉴로!");
                break;
            case "StartBtn":
                SceneManager.LoadScene("InGame");
                Debug.Log("시작!");
                break;
            case "SetBtn":
                Debug.Log("세팅세팅!");
                break;
            case "leaveBtn":
                Debug.Log("안해! 안해!");
                end();
                break;
            case "CLOSE":
                boxwindow.SetActive(false);
                break;
        }
    }
    void end()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
