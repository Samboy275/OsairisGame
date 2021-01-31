using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzler : MonoBehaviour
{

    public Sprite[] pallettes;
    public SpriteRenderer wallSprtie;
    public int currentIndex =0;

    public int size = 3;
    // Start is called before the first frame update
    void Start()
    {
        wallSprtie = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSprite()
    {

        wallSprtie.sprite = pallettes[currentIndex];
        currentIndex++;
        if (currentIndex >= size)
            currentIndex = 0;
    }
}
