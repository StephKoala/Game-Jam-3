using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour 
{

    //Create instance
    public static MainMenu instance;

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


}
