using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityManager : MonoBehaviour
{
    public float velocity = 1f;
    [SerializeField] private float scale = 0.01f;
    [SerializeField] private float nextTimeToIncrease = 10;

    [SerializeField] private float increaseRate = 10;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time >= nextTimeToIncrease)
        {
            velocity += scale;
            nextTimeToIncrease = Time.time + increaseRate;
            Debug.Log(velocity);
        }
    }
}
