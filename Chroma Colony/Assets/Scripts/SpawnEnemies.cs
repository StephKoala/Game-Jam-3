using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public List<GameObject> spawns;
    public List<GameObject> enemies;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnEnemy()
    {
        int spawnsIndex = Random.Range(0, spawns.Count);
        int enemiesIndex = Random.Range(0, enemies.Count);
        Instantiate(enemies[enemiesIndex], spawns[spawnsIndex].transform.position, enemies[enemiesIndex].transform.rotation);
    }
}
