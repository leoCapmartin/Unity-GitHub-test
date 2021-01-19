using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider player)
    {
        if(player.name == "Player" && !gameManager.IsGameEnded())
            gameManager.WonLevel();
    }
}
