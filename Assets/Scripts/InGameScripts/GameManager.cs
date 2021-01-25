using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private bool _gameHasEnded;
    public float restartDelay = 1f;
    public GameObject completeLevelUi;
    public GameObject score;

    public bool IsGameEnded()
    {
        return _gameHasEnded;
    }
    public void EndGame()
    {
        if (!_gameHasEnded)
        {
            _gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }

    public void WonLevel()
    {
        _gameHasEnded = true;
        completeLevelUi.SetActive(true);
        score.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
