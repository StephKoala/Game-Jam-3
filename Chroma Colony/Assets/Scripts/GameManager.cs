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
    private bool isPaused; 
    private bool isWriteBlock;
    public TextMeshProUGUI powerText;

    //Create instance
    public static GameManager instance;

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
        isWriteBlock = false;
    }

    // Update is called once per frame
    void Update()
    {
        TextUpdate();
    }

    //PauseGame
    public void PauseGame()
    {
        if (!isPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        isPaused = !isPaused;
    }

    private void TextUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            powerText.text = powerText.text + "Q";
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            powerText.text = powerText.text + "W";
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            powerText.text = powerText.text + "E";
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            powerText.text = powerText.text + "R";
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            powerText.text = powerText.text + "T";
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            powerText.text = powerText.text + "Y";
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            powerText.text = powerText.text + "U";
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            powerText.text = powerText.text + "I";
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            powerText.text = powerText.text + "O";
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            powerText.text = powerText.text + "P";
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            powerText.text = powerText.text + "A";
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            powerText.text = powerText.text + "S";
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            powerText.text = powerText.text + "D";
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            powerText.text = powerText.text + "F";
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            powerText.text = powerText.text + "G";
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            powerText.text = powerText.text + "H";
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            powerText.text = powerText.text + "J";
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            powerText.text = powerText.text + "K";
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            powerText.text = powerText.text + "L";
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            powerText.text = powerText.text + "Z";
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            powerText.text = powerText.text + "X";
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            powerText.text = powerText.text + "C";
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            powerText.text = powerText.text + "V";
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            powerText.text = powerText.text + "B";
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            powerText.text = powerText.text + "N";
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            powerText.text = powerText.text + "M";
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            isWriteBlock = true;
            StartCoroutine(TimeToWrite());
        }
    }

    IEnumerator TimeToWrite()
    {
        yield return new WaitForSeconds(0.5f);
        isWriteBlock = false;
        powerText.text = "";
    }
}