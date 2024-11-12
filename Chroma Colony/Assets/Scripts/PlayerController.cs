using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Declarations
    public int lifes;
    private SpawnEnemies spawnEnemiesScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( lifes <= 0)
        {
            spawnEnemiesScript = GameObject.FindGameObjectWithTag("Player").GetComponent<SpawnEnemies>();
            spawnEnemiesScript.gameOver = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            lifes--;
            Destroy(collision.gameObject);
        }
    }
}
