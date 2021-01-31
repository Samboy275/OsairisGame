using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPuzzle : MonoBehaviour
{

    /// <summary>
    /// the puzzle solution is by placing sprites identical to the opposite column while the middle
    /// sprite is the same as the middle column the right sprite should match the left column and the left 
    /// sprtie match the right column the puzzle applies to the right columns only 
    /// after solution spawn heart in the door area or end the lvl
    /// 
    /// hint to the puzzle "the middle man reflects the pictures of the opposing side to the other"
    /// </summary>
    public Sprite[] correctPattern;
    public SpriteRenderer[] playerInput;

    bool  solved = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(solved)
        {
            Debug.Log("solved");
        }
        else
        {
            if (correctPattern[0] == playerInput[0].sprite &&
                correctPattern[1] == playerInput[1].sprite &&
                correctPattern[2] == playerInput[2].sprite)
                solved = true;
        }
    }
}
