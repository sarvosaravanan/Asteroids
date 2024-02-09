using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumyUb : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
      rb=GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    private void FixedUpdate()
    {
        rb.velocity=Vector2.up*speed;
        
    }
}
