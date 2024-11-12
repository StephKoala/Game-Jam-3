using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //Declarations
    public float movementSpeed;
    public List<string> enemyClass;
    public List<string> enemyColor;
    public List<GameObject> enemyIdle;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(GameManager.instance.powerText.text == "RED")
            {
                Destroy(gameObject);
            }
        }
    }
}
