using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Declaraciones
    public float movementSpeed;
    public List<string> enemyColor;
    public List<Sprite> enemyIdle;
    public List<RuntimeAnimatorController> enemyAnimators;
    private Transform playerTransform;
    public bool isLive;

    // Características del enemigo
    private SpriteRenderer enemySpriteRenderer;
    private string color;

    // Referencia al Animator
    private Animator animator;

    // Sonidos
    public AudioClip hitEnemyAudioClip;

    //TextColor
    private LevelManager levelManagerScript;

    // Start se llama antes de la primera actualización del frame
    void Start()
    {
        isLive = true;
        int index = Random.Range(0, enemyColor.Count);
        enemySpriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>(); // Obtenemos el Animator del enemigo
        color = enemyColor[index];
        animator.runtimeAnimatorController = enemyAnimators[index];

        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        FlipSprite();
    }

    // Update se llama una vez por frame
    void Update()
    {
        if (isLive)
        {
            Movment();
        }
        ViewText();
    }

    private void FlipSprite()
    {
        if (transform.position.x > 0)
        {
            enemySpriteRenderer.flipX = true;
        }
    }

    private void Movment()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, movementSpeed * Time.deltaTime);
    }

    private void ViewText()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            levelManagerScript = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<LevelManager>();
            if (levelManagerScript.powerText.text == color)
            {
                AudioManager.instance.PlaySFX(hitEnemyAudioClip);
                isLive = false;
                // animation
                animator.SetBool("onDeath", true);
                StartCoroutine(DestroyEnemy());
            }
        }
    }

    IEnumerator DestroyEnemy()
    {
        yield return new WaitForSeconds(2); 
        Destroy(gameObject);
    }
}