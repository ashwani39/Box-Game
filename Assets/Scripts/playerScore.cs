using UnityEngine;
using UnityEngine.UI;

public class playerScore : MonoBehaviour
{
    public Transform playerDistance;
    public Text ScoreText;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = playerDistance.position.z.ToString("0");
    }
}
