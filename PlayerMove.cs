using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float H;
    [SerializeField] float rotateSpeed = 10f;
    [SerializeField] float speed = 10f;


    [SerializeField] Transform SpawnPoint;
    [SerializeField] GameObject Bullet;
    bool isPalying;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        H += Input.GetAxis("Horizontal");
      

        transform.rotation = Quaternion.Euler( 0f,0f,H*rotateSpeed);

        if((Input.GetKey(KeyCode.UpArrow))||(Input.GetKey(KeyCode.W)))
        {
            transform.Translate(Vector2.up*speed*Time.deltaTime);
        }

        BulletSpawn();
    }
    void BulletSpawn()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject G = Instantiate(Bullet);
            G.transform.position = SpawnPoint.transform.position;
            G.transform.rotation =SpawnPoint. transform.rotation;
        }

    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Enumy")
    //    {
    //        Destroy(collision.gameObject);
    //    }
    //}




}
