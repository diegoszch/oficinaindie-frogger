using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public bool isRight = true;

    public float baseSpeed;

    private float speed;

    private int multiply;

    void Start()
    {
        Destroy(gameObject, 10);

        speed = baseSpeed;
        multiply = 1;
    }

    public void AddVelocity()
    {
        multiply++;
    }

    void Update()
    {
        transform.position += new Vector3(isRight ? speed : -speed, 0, 0) * Time.deltaTime * multiply;
    }
}
