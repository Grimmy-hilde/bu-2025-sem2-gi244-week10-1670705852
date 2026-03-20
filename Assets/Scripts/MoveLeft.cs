using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed;

    public float fristSpeed = 10f;

    private float leftBound = -15;

    private PlayerController playerController;

    void Start()
    {
        speed = fristSpeed;
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!playerController.gameOver)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        
    }

    private void FixedUpdate()
    {
        if (playerController.speedAction.IsPressed())
        {
            speed = fristSpeed * 2 ;
        }
        else
        {
            speed = fristSpeed;
        }
    }
}
