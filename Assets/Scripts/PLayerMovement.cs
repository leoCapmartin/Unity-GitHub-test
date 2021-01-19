using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 1500f;

    public float sidewaysForce = 500f;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("q"))
        {
            rb.AddForce(-sidewaysForce*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }

        if (rb.position.y <= 0f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
