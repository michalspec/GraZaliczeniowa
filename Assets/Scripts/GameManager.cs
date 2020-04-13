using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float delay = 1.5f;
    public bool isGameEnded = false;
    public GameObject LevelCompleteUI;
    public void EndGame()
    {
        
        if (!isGameEnded)
        {
            isGameEnded = true;
            Debug.Log("GAME MOVEr");
            Invoke("Restart", delay);
        }
    }

    public void CompleteLevel()
    {
        Debug.Log("Level One");
        LevelCompleteUI.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
