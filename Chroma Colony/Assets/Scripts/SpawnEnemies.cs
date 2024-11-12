using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public List<GameObject> spawns;
    public List<GameObject> enemies;
    public float speed;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        StartCoroutine(SpawnEnemy());
        InvokeRepeating("ChangeSpeed", 20, 20);
        InvokeRepeating("ChangeSpeedEndGame", 240, 60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemy()
    {
        while (!gameOver)
        {
            int spawnsIndex = Random.Range(0, spawns.Count);
            int enemiesIndex = Random.Range(0, enemies.Count);
            Instantiate(enemies[enemiesIndex], spawns[spawnsIndex].transform.position, enemies[enemiesIndex].transform.rotation);
            yield return new WaitForSeconds(speed);
        }
    }
    private void ChangeSpeed()
    {
        if(speed > 0.5f)
        {
            speed -= 0.5f;
        }      
    }
    private void ChangeSpeedEndGame()
    {
        if (speed > 0.1f)
        {
            speed -= 0.1f;
        }
    }
}
