
using UnityEngine;
using UnityEditor.SceneManagement;
public class LoadMenu : MonoBehaviour
{
    private string menuScene = "MainMenu";
    // Start is called before the first frame update
    public void Load_Menu()
    {
        EditorSceneManager.LoadScene(menuScene);
    }
}
