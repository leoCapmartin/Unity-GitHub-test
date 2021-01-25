using System;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public float distance = 1f;
    private float _nextTimeToIncrease;
    private int _score = 0;
    private VelocityManager _velocityManager;

    void Start()
    {
        _velocityManager = FindObjectOfType<VelocityManager>();
        _nextTimeToIncrease = Time.time + distance / _velocityManager.velocity;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time >= _nextTimeToIncrease)
        {
            _score++;
            _nextTimeToIncrease = Time.time + distance / _velocityManager.velocity;
        }
        
        scoreText.text = _score.ToString("0");
    }
}
