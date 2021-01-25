using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float backwardForce;
    private VelocityManager velocityManager;
    private float velocity = 1f;

    void Start()
    {
        velocityManager = GetComponentInParent<VelocityManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        velocity = velocityManager.velocity;
        rb.AddForce(0,0, -backwardForce * velocity * Time.fixedDeltaTime, ForceMode.VelocityChange);

        if (transform.position.z <= -10)
        {
            Destroy(transform.gameObject);
        }
    }
}
