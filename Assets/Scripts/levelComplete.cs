using UnityEngine.SceneManagement;
using UnityEngine;

public class levelComplete : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
