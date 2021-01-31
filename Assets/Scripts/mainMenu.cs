    using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    
    public void LSelect(string levelName)
    {
      //  SceneManager.LoadScene(levelName);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
