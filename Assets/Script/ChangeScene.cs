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
                Debug.Log("��������!");
                break;
            case "outBtn":
                SceneManager.LoadScene("Mainmenu");
                Debug.Log("���θ޴���!");
                break;
            case "StartBtn":
                SceneManager.LoadScene("InGame");
                Debug.Log("����!");
                break;
            case "SetBtn":
                Debug.Log("���ü���!");
                break;
            case "leaveBtn":
                Debug.Log("����! ����!");
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
