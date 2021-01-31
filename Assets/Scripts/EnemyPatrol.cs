using UnityEngine;
using System.Collections;

public class EnemyPatrol : MonoBehaviour
{
    Rigidbody2D enemyRigidBody2D;
    public int UnitsToMove = 5;
    public float EnemySpeed = 500;
    public bool _isFacingRight;
    private float _startPos;
    private float _endPos;
    public Animator anim;
    public bool _moveRight = true;
    public GameObject Player;
    private bool PlayerFound = false;


    // Use this for initialization
    public void Awake()
    {
        anim = GetComponent<Animator>();
        enemyRigidBody2D = GetComponent<Rigidbody2D>();
        _startPos = transform.position.x;
        _endPos = _startPos + UnitsToMove;
        _isFacingRight = transform.localScale.x > 0;
    }


    // Update is called once per frame
    public void FixedUpdate()
    {


        if (_moveRight && !PlayerFound)
        {
            enemyRigidBody2D.velocity = (Vector2.right * EnemySpeed * Time.deltaTime);
            if (!_isFacingRight)
                Flip();
            
        }

        if (enemyRigidBody2D.position.x >= _endPos && !PlayerFound)
            _moveRight = false;

        if (!_moveRight && !PlayerFound)
        {
            enemyRigidBody2D.velocity = (-Vector2.right * EnemySpeed * Time.deltaTime);
            if (_isFacingRight)
                Flip();
            
        }
        if (enemyRigidBody2D.position.x <= _startPos && !PlayerFound)
            _moveRight = true;

        if(Vector2.Distance(this.transform.position , Player.transform.position) < 2)
        {
            PlayerFound = true;
            anim.SetBool("Attack", true);
            anim.SetBool("Run", false);
        }
        else
        {
            PlayerFound = false;
            anim.SetBool("Run", true);
        }
    }

    public void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        _isFacingRight = transform.localScale.x > 0;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            PlayerHealth.Instance.Hp -= 5;
        }
    }

}