using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PLayerMovement mouvement;
    
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            mouvement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
