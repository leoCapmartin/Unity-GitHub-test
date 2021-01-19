using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObstacles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child  in this.transform)
        {
            GameObject obstacle = child.gameObject;
            obstacle.SetActive(true);
        }
    }
}
