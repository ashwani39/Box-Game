using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public gameManager gamemanager;
    void OnTriggerEnter()
    {
        gamemanager.levelFinished();
    }
}
