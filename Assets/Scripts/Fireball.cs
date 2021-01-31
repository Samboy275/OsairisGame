using UnityEngine;

public class Fireball : MonoBehaviour
{

    public float fireSpeed = 10;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * fireSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        
    }
}
