using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float restartDelay = 2.0f;
    public GameObject completeLevelUI;

    
   public void EndGame()
    {
        

        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Oops");
            Invoke("Restart", restartDelay);
        }
        

        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void levelFinished()
    {
        completeLevelUI.SetActive(true);
    }
}
