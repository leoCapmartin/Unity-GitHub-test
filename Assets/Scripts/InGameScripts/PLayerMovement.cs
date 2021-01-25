using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    public float speed = 6f;

    [SerializeField] private Transform cam;
    [SerializeField] private Vector3 offset;

    private VelocityManager _velocityManager;
    private GameManager _gameManager;

    void Start()
    { 
        _velocityManager = FindObjectOfType<VelocityManager>();
        _gameManager = FindObjectOfType<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        // update position
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector3 move = new Vector3(horizontal * speed, 0f, 0f);

        if (move.magnitude != 0f)
            controller.Move(move * (_velocityManager.velocity * Time.deltaTime));

        // update camera
        cam.position = transform.position + offset;
    }
}
