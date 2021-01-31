using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    
   

    public GameObject key;

    bool open = false;
    // Start is called before the first frame update
    void Start()
    {
      if (open)
        {
            open = false;
            
        }
    }


  
    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(PlayerHealth.Instance.getKey)
            {
                key.SetActive(true);
                Debug.Log("PlacedKey");
                PlayerHealth.Instance.getKey = false;
                open = true;
                key.GetComponent<SpriteRenderer>().color = Color.black;
                GetComponent<SpriteRenderer>().color = Color.black;
                
                GameManager.instance.LoadNextScene();
            }
        }
    }
}
