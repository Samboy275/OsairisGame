using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private bool gameOver = false;

    
    [SerializeField]
    
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(instance);
       
    }

    // Update is called once per frame
    void Update()
    {
        //open door for next lvl
        
            
           
    }

    public void LoadNextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void PlayerDied()
    {
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "TheEscape")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver1");
        }
        else if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Chamber of Seth")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver2");
        }
    }


    
    
}
