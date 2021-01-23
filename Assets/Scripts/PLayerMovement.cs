using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float sidewaysForce = 500f;
    // Update is called once per frame
    void FixedUpdate()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        rb.AddForce(sidewaysForce * moveX * Time.fixedDeltaTime,0,0, ForceMode.VelocityChange);

        if (rb.position.y <= 0f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
