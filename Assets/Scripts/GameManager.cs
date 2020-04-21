using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float delay = 1.5f;
    public bool isGameEnded = false;
    public GameObject LevelCompleteUI;
    public GameObject BonusImage;
    public GameObject BonusScore;
    private GameObject activeObject;
    public int points = StoreData.score;

    private void Start()
    {
        activeObject = GameObject.Find("BonusPoint");
    }
    public void EndGame()
    {
        
        if (!isGameEnded)
        {
            if(activeObject != null) 
            {
                activeObject.SetActive(false);
            }
            isGameEnded = true;
            Debug.Log("GAME MOVEr");
            Invoke("Restart", delay);
        }
    }

    public void CompleteLevel()
    {
        Debug.Log("Level One");
        BonusImage.SetActive(false);
        BonusScore.SetActive(false);
        StoreData.score = points;
        LevelCompleteUI.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
