using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor.Animations;

public class PlayerController : MonoBehaviour
{
    //Declarations
    public int lifes;
    private SpawnEnemies spawnEnemiesScript;
    private Chronometer chronometerScript;
    private TimeToDraw timeToDrawScript;
    private LevelManager levelManagerScript;
    private bool isLive;
    public GameObject explosion;

    //Lifes
    private int index;
    public List<GameObject> lifesHearth;

    //Sounds
    public AudioClip collisionAudioClip;

    //animations 
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        isLive = true;
        index = 5;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( lifes <= 0)
        {
            spawnEnemiesScript = GameObject.FindGameObjectWithTag("Spawn").GetComponent<SpawnEnemies>();
            chronometerScript = GameObject.FindGameObjectWithTag("Chronometer").GetComponent<Chronometer>();
            timeToDrawScript = GameObject.FindGameObjectWithTag("Draw").GetComponent<TimeToDraw>();
            levelManagerScript = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<LevelManager>();
            spawnEnemiesScript.gameOver = true;
            chronometerScript.gameOver = true;
            timeToDrawScript.gameOver = true;
            levelManagerScript.gameOver = true;
            isLive = false;
            //Animation
            animator.SetBool("onDeath", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            index--;
            lifes--;

            if(index >= 0)
            {
                lifesHearth[index].SetActive(false);
            }

            AudioManager.instance.PlaySFX(collisionAudioClip);
            //AnimationExplosion
            StartCoroutine(DestroyEnemy());
            //Instantiate(explosion, transform.position, explosion.rotation);
            GameObject explosionInstance = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }

    IEnumerator DestroyEnemy()
    {
        yield return new WaitForSeconds(3);
    }
}
