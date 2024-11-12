using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //Declarations
    public float movementSpeed;
    public List<string> enemyColor;
    public List<Sprite> enemyIdle;
    private Transform playerTransform;

    //Enemy Traits
    private SpriteRenderer enemySpriteRenderer;
    private string color;

    //Sounds
    public AudioClip hitEnemyAudioClip;

    // Start is called before the first frame update
    void Start()
    {
        int index = Random.Range(0, enemyIdle.Count);
        enemySpriteRenderer = GetComponent<SpriteRenderer>();
        enemySpriteRenderer.sprite = enemyIdle[index];
        color = enemyColor[index];

        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Movment();
        ViewText();
    }

    private void Movment()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, movementSpeed * Time.deltaTime);
    }

    private void ViewText()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(GameManager.instance.powerText.text == color)
            {
                AudioManager.instance.PlaySFX(hitEnemyAudioClip);
                Destroy(gameObject);
            }
        }
    }
}
