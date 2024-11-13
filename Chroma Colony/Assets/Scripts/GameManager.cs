using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Declarations
    public bool isPaused;

    //Create instance
    public static GameManager instance;

    public GameObject mainMenu;

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

    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    //PauseGame
    public void PauseGame()
    {
        Time.timeScale = 0f;

        /*
        if (!isPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        isPaused = !isPaused;
        */
    }

    //PauseGame
    public void UnpauseGame()
    {
        Time.timeScale = 1f;

        /*
        if (!isPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        isPaused = !isPaused;
        */
    }

    public void SetMainMenuToActive() {
        mainMenu.SetActive(true);
    }
    
}