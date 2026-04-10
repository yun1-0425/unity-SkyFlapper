using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public float deadRotate = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            flap(flapStrength);
            //Debug.Log("Space pressed");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
        rb.angularVelocity = deadRotate;

        if (collision.gameObject.tag == "BottomWall")
        {
            flap(flapStrength*2);
        }
    }

    void flap(float strength)
    {
        rb.linearVelocity = Vector2.up * strength;
    }
}
