
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public void Start()
    {
        Time.timeScale = 1;
    }

    public void gameOver()
    {
        Time.timeScale = 0;
        Debug.Log("Game Over");
        
    }


}
