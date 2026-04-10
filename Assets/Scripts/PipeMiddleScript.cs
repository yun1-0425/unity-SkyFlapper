using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public BirdScript bird;
    public LogicScript logic;
    public AudioClip dingClip;
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bird" && bird.birdIsAlive) {
            logic.addScore(1);
            audioSource.PlayOneShot(dingClip);
        }
    }
}
