using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackFlames : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;
    private float endYPOS = 33.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < endYPOS)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
        else
        {
            Destroy(this);
        }
    }
}
