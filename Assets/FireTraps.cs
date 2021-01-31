using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTraps : MonoBehaviour
{
    private int index;

    private GameObject[] arrows;
    public int size = 9;
    public float shooTime = 2;
    public GameObject arrow;
    private float lastSetTime;
    private Vector2 spawnPosition = new Vector2(35.5f, 4f);
    // Start is called before the first frame update
    void Awake()
    {
        arrows = new GameObject[size];
        for(int i = 0; i < size; i++)
        {
            
            arrows[i] = Instantiate(arrow, spawnPosition += Vector2.right * 0.7f, Quaternion.AngleAxis(270, Vector3.forward));
            arrows[i].GetComponent<ArrowMovement>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        lastSetTime += Time.deltaTime;
        if(lastSetTime >= shooTime)
        {
            lastSetTime = 0;
            arrows[index].transform.position = spawnPosition;
            arrows[index].GetComponent<ArrowMovement>().enabled = true;

            
            index++;
            
            if(index >= size)
            {
                
                index = 0;
            }
        }
        
    }
    

   
}
