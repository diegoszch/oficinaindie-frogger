using UnityEngine;

public class FroggerScore : MonoBehaviour
{
    private Vector3 initialPosition;

    public int score = 0;

    void Start()
    {
        initialPosition = transform.position;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            transform.position = initialPosition;
        }

        if (collision.gameObject.name == "Finished")
        {
            transform.position = initialPosition;
            score++;
        }
    }
}