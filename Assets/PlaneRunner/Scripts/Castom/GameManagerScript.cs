using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerScript : MonoBehaviour
{
    [SerializeField] string sceneName;
    public void RestartGame()
    {
        if(sceneName != null && sceneName != "")
        {
            SceneManager.LoadScene(sceneName);
        }
        
    }
}
