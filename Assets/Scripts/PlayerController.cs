using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;

    public float speed;
    public float jumpForce;


    private float moveInput;
    private Rigidbody2D rb;
    private bool facingR = true;


    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask groundType;

    public int airJumpValue;
    private int airJumps;

    public Transform firePoint;
    public GameObject fireball;
    private bool inputEnabled =true;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        airJumps = airJumpValue;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundType);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (!facingR && moveInput > 0)
        {
            Flip();
        }
        else if (facingR && moveInput < 0)
        {
            Flip();
        }

    }
    void Update()
    {
        
        if (isGrounded)
        {
            anim.SetBool("Jump", false);
            airJumps = airJumpValue;
        }
        if(Mathf.Abs(moveInput) > 0)
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }

        
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            anim.SetBool("Jump", true);
            rb.velocity = Vector2.up * jumpForce;
        }
        else if (Input.GetButtonDown("Jump") && airJumps >0)
        {
            anim.SetBool("Jump", true);
            rb.velocity = Vector2.up * jumpForce;
            airJumps--;

        }
        if(Input.GetButtonDown("Fire1") && inputEnabled)
        {
            StartCoroutine(shoot());

        }


    }
    void Flip()
    {
        facingR = !facingR;
        transform.Rotate(0f, 180, 0f);
    }
    
    IEnumerator shoot()
    {
        inputEnabled = false;
        anim.SetBool("isFire", true);
        yield return new WaitForSeconds(0.7f);
        Instantiate(fireball, firePoint.position, firePoint.rotation);
        anim.SetBool("isFire", false);
        inputEnabled = true;
    }

}

