using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToDraw : MonoBehaviour
{
    //Declarations
    public bool gameOver;
    public List<GameObject> buildings;

    //Sounds
    public AudioClip buildingAudioClip;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DrawBuildings());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DrawBuildings()
    {
        int index = 0;
        yield return new WaitForSeconds(20);
        while (!gameOver && index < buildings.Count)
        {
            AudioManager.instance.PlaySFX(buildingAudioClip);
            buildings[index].SetActive(true);
            index++;
            yield return new WaitForSeconds(20);
        }  
    }
}
