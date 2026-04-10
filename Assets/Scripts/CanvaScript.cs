using UnityEngine;

public class CanvaScript : MonoBehaviour
{
    public LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pauseGame()
    {
        logic.pauseGame();
    }

    public void resumeGame()
    {
        logic.resumeGame();
    }
}
