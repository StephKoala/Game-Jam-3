using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //Declarations
    private bool isWriteBlock;
    public bool gameOver;
    public TextMeshProUGUI powerText;

    //Sounds
    public AudioClip keyDownAudioClip;

    // Start is called before the first frame update
    void Start()
    {
        isWriteBlock = false;
        powerText = GameObject.FindGameObjectWithTag("TextUI").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isWriteBlock && !gameOver && powerText.text.Length < 6)
        {
            TextUpdate();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            isWriteBlock = true;
            StartCoroutine(TimeToWrite());
        }
    }

    private void TextUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            powerText.text = powerText.text + "Q";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            powerText.text = powerText.text + "W";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            powerText.text = powerText.text + "E";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            powerText.text = powerText.text + "R";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            powerText.text = powerText.text + "T";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            powerText.text = powerText.text + "Y";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            powerText.text = powerText.text + "U";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            powerText.text = powerText.text + "I";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            powerText.text = powerText.text + "O";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            powerText.text = powerText.text + "P";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            powerText.text = powerText.text + "A";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            powerText.text = powerText.text + "S";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            powerText.text = powerText.text + "D";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            powerText.text = powerText.text + "F";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            powerText.text = powerText.text + "G";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            powerText.text = powerText.text + "H";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            powerText.text = powerText.text + "J";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            powerText.text = powerText.text + "K";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            powerText.text = powerText.text + "L";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            powerText.text = powerText.text + "Z";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            powerText.text = powerText.text + "X";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            powerText.text = powerText.text + "C";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            powerText.text = powerText.text + "V";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            powerText.text = powerText.text + "B";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            powerText.text = powerText.text + "N";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            powerText.text = powerText.text + "M";
            AudioManager.instance.PlaySFX(keyDownAudioClip);
        }
    }

    IEnumerator TimeToWrite()
    {
        yield return new WaitForSeconds(0.5f);
        isWriteBlock = false;
        powerText.text = "";
    }
}
