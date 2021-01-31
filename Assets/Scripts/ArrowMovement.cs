using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public Vector2 initial_position;
  
    public float speed = 5.0f;
    private void Awake()
    {
        initial_position = transform.position;
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
        rb2d.velocity = transform.right * speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "SolidPlatform")
        {
            this.enabled = false;
            transform.position = initial_position;
            
        }
    }
}
