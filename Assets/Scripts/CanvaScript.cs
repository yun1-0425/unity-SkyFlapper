using UnityEngine;

public class CanvaScript : MonoBehaviour
{
    public GameObject pauseScreen;
    public LogicScript logic;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    public void pauseGame()
    {
        Debug.Log("pauseGame");
        logic.pauseGame();
        pauseScreen.SetActive(true);
    }

    public void resumeGame()
    {
        Debug.Log("resumeGame");
        logic.resumeGame();
        pauseScreen.SetActive(false);
    }
}
