using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
  public void LoadNextLevel()
    {
        int level = SceneManager.GetActiveScene().buildIndex;
        
      //  Debug.Log("LOAD the NEXT LEVEL");
        SceneManager.LoadScene(level + 1);
    }
}
