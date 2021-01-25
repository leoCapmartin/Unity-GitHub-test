using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PLayerMovement mouvement;
    public Transform movingObstacles;
    
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            foreach (Transform child in movingObstacles)
            {
                child.GetComponent<ObstacleMovement>().enabled = false;
            }
            mouvement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
