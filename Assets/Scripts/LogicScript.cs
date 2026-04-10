using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    public Button pauseButton;
    //public BirdScript bird;

    public float initialMoveSpeed = 5;
    // public float initialSpawnRate = 5;

    // public float moveSpeed = 5;
    // public float spawnRate = 5;
    public float scoreToIncreaseSpeed = 10;
    public float speedIncreaseRate; // 其他檔案要讀的

    public void Start()
    {
        //bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }

    public void Update()
    {
        speedIncreaseRate = 1 + score / scoreToIncreaseSpeed;
        // moveSpeed = initialMoveSpeed * speedIncreaseRate;
        // spawnRate = initialSpawnRate / speedIncreaseRate;
        // //moveSpeed = initialMoveSpeed * (1 + score) / speedIncreaseRate;
        // //spawnRate = initialSpawnRate / (1 + score) * speedIncreaseRate;
    }

    [ContextMenu("Add Score")]
    public void addScore(int scoreToAdd) {
        // if (bird.birdIsAlive)
        // {}
        score += scoreToAdd;
        scoreText.text = score.ToString();

        // Debug.Log("moveSpeed: " + moveSpeed);
        // Debug.Log("spawnRate: " + spawnRate);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        pauseButton.interactable = false;
    }

    public void pauseGame()
    {
        Time.timeScale = 0;
    }

    public void resumeGame()
    {
        Time.timeScale = 1;
    }
}
