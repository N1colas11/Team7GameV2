using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{

    public int damage = 1;
    public float speed;

    //public GameObject gruntSound;
    public GameObject heartSound;
    public GameObject blood;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x <= -3)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //Instantiate(gruntSound, transform.position, Quaternion.identity);
            Instantiate(heartSound, transform.position, Quaternion.identity);
            Instantiate(blood, transform.position, Quaternion.identity);
            other.GetComponent<player>().health += damage;
            Debug.Log(other.GetComponent<player>().health);
            Destroy(gameObject);
        }
    }
}
