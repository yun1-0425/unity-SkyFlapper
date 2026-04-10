using UnityEngine;

public class BackMoveScript : MonoBehaviour
{
    public LogicScript logic;
    //public PipeMoveScript pipeMove;
    private float initialMoveSpeed;
    private float moveSpeed = 5;
    public float repeatZone = -57.5f;
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
        moveSpeed = initialMoveSpeed * speedIncreaseRate * 0.8f;
        transform.position += Vector3.left *moveSpeed * Time.deltaTime;
        //Debug.Log(transform.position.x);

        if (transform.position.x < repeatZone)
        {
            
            //transform.position += Vector3.right * repeatZone * 2;
            transform.position = new Vector3(57.5f, transform.position.y, transform.position.z);
        }
    }
}
