using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratesObstacles : MonoBehaviour
{
    [SerializeField] private float spawnRate;
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private VelocityManager velocityManager;
    private float _nextTimeToSpawn = 1f;
    // Update is called once per frame
    void Update()
    {
        spawnRate = 0.5f + velocityManager.velocity/4;
        if (Time.time >= _nextTimeToSpawn)
        {
            int nbObstacleToSpawn = Random.Range(1, 7);
            List<int> positions = new List<int>() {-4, -3, -2, -1, 0, 1, 2, 3, 4};
            for (int i = 0; i < nbObstacleToSpawn; i++)
            {
                int j = Random.Range(0, positions.Count);
                float x = positions[j]*2;
                positions.RemoveAt(j);

                Vector3 pos = new Vector3(x, 1, 60);
                Instantiate(obstaclePrefab, pos, Quaternion.identity, transform.GetChild(2));
                
            }
            _nextTimeToSpawn = Time.time + spawnRate;
        }
    }
}
