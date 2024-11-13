using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class EnemyController : MonoBehaviour
{
    // Declaraciones
    public float movementSpeed;
    public List<string> enemyColor;
    public List<Sprite> enemyIdle;
    public List<AnimatorController> enemyAnimators;
    private Transform playerTransform;

    // Caracter�sticas del enemigo
    private SpriteRenderer enemySpriteRenderer;
    private string color;

    // Referencia al Animator
    private Animator animator;

    // Sonidos
    public AudioClip hitEnemyAudioClip;

    // Start se llama antes de la primera actualizaci�n del frame
    void Start()
    {
        int index = Random.Range(0, enemyColor.Count);
        enemySpriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>(); // Obtenemos el Animator del enemigo
        color = enemyColor[index];
        animator.runtimeAnimatorController = enemyAnimators[index]; 

        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        FlipSprite();

        // Iniciar en la animaci�n Idle
        animator.Play("Idle");
    }

    // Update se llama una vez por frame
    void Update()
    {
        Movment();
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
        // Cambiamos a la animaci�n de movimiento cuando el enemigo se mueve
        animator.SetBool("isMoving", true); // Activa la animaci�n de movimiento
        transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, movementSpeed * Time.deltaTime);
    }

    private void ViewText()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (GameManager.instance.powerText.text == color)
            {
                AudioManager.instance.PlaySFX(hitEnemyAudioClip);
                Destroy(gameObject);
            }
        }
    }
}

