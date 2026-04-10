using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public LogicScript logic;
    private float initialMoveSpeed;
    private float moveSpeed = 5;
    public float deadZone = -50;
    public float speedIncreaseRate; // 從 logic 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        initialMoveSpeed = logic.initialMoveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        speedIncreaseRate = logic.speedIncreaseRate;
        moveSpeed = initialMoveSpeed * speedIncreaseRate;
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            //Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
