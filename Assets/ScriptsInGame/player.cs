using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health;

    public Text healthDisplay;

    public GameObject gameOver;
    public GameObject moveSound;

    void Update()
    {
        healthDisplay.text = health.ToString();

        if(health >= 5)     //Max of 5 HP
        {
            health = 5;
        }

        if (health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight) {
            Instantiate(moveSound, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight) {
            Instantiate(moveSound, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }
            
    }
}
