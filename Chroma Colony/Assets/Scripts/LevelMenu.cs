using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour {

    public void GoToMainMenu() {
        SceneManager.LoadScene(0);
    }

    public void PauseGame() {
        Time.timeScale = 0.0f;
    }
    public void UnpauseGame() {
        Time.timeScale = 1.0f;
    }


}
