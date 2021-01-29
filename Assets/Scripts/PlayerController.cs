using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject fireball;
    public Transform fireposition;
    public Animator anim;

    private bool inputEnable = true;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(inputEnable)
        {
            if (Input.GetKey(KeyCode.F))
            {
                StartCoroutine(ShootFire());
            }
        }
     
    }


    IEnumerator ShootFire()
    {
        inputEnable = false;
        anim.SetBool("isFire", true);
        yield return new WaitForSeconds(0.7f);
        Instantiate(fireball, fireposition.transform.position, fireposition.rotation);
        anim.SetBool("isFire", false);
        inputEnable = true;
    }
}
