using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.EventSystems.EventTrigger;

public class MainMenu : MonoBehaviour 
{

    //Create instance
    public static MainMenu instance;
    public GameObject gameOverUI;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PlayGame() {
        SceneManager.LoadScene("Level");
    }

    public void GoToMainMenu() {
        SceneManager.LoadScene(0);
    }

    public void SetGameOverToActive()
    {
        gameOverUI.SetActive(true);
    }
}
