using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideWayForce = 500f;
    // Start is called before the first frame updateif(

    // Update is called once per frame
    //fixed update pe physics hota
    void FixedUpdate()
    {
        //this is to add force to our player
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1)
        {
            FindObjectOfType<gameManager>().EndGame();
        }
    }
}
