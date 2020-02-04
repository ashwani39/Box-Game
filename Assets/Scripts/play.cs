using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    // Start is called before the first frame update
    public void playNow()
    {
        Debug.Log("clicked");
        SceneManager.LoadScene("Level01");
    }
}
