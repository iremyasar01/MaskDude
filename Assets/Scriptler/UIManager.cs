using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{


    public static UIManager Instance;

    public GameObject BaslangicPaneli;
    public GameObject LevelCompletedPanel;
    public GameObject QuitPanel;

    private void Awake()
    {
        Instance = this;

    }
    public void StartButon()
    {
        SceneManager.LoadScene(1);
        BaslangicPaneli.SetActive(false);
        
    }
    
    public void NextLevelButton()
    {
        GameManager.instance.NextScene();
        CloseLevelCompletedPanel();
    }
    public void OpenLevelCompletedPanel()
    {
        LevelCompletedPanel.SetActive(true);
    }
    public void CloseLevelCompletedPanel()
    {
        LevelCompletedPanel.SetActive(false);
    }

    public void QuitButton()
    {
        print("end");
        Application.Quit();
    }
    public void OpenQuitPanel()
    {
        QuitPanel.SetActive(true);
    }
}