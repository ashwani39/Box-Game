using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerController movement;
    void OnCollisionEnter(Collision collsionInfo)
    {
       
        if(collsionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<gameManager>().EndGame();
        }
    }

}
