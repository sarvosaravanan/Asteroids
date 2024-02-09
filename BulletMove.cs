using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{

    Rigidbody2D rb;
    [SerializeField] float speed=10f;   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Destroy(gameObject, 2f);
       
    }
    void FixedUpdate()
    {
         rb.velocity=transform.up*speed;

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enumy"))
        {
           
           Destroy(collision.gameObject);

           ScoreManager.instance.CountScore(1);

            

        }
    }

   
}
