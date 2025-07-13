using UnityEngine;

public class FroggerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float speed;

    private Vector2 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (speed == 0)
            speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction = Vector2.down;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direction = Vector2.right;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            direction = Vector2.left;
        }
        else
        {
            direction = Vector2.zero;
        }

        // input.x = Input.GetAxis("Horizontal");
        // input.y = Input.GetAxis("Vertical");
        // input.Normalize(); // Mantém velocidade consistente na diagonal
    }

    void FixedUpdate()
    {
        // if (input.x > 0)
        //     rb.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
        // else if (input.x < 0)
        //     rb.AddForce(Vector2.left * speed, ForceMode2D.Impulse);

        // if (input.y > 0)
        //     rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
        // else if (input.y < 0)
        //     rb.AddForce(Vector2.down * speed, ForceMode2D.Impulse);

        rb.linearVelocity = direction * speed;

        //rb.AddForce(direction * speed, ForceMode2D.Impulse);
    }
}
