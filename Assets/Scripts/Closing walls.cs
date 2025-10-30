using UnityEngine;

public class Closingwalls : MonoBehaviour
{
    public Vector3 targetPosition; // The final position the wall will move to
    public float speed = 1f;       // Speed of wall movement
    public bool canMove = true;

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position; // Store the starting position
    }

    void Update()
    {
        if (canMove) // Only move if canMove is true
        {
            // Move the wall towards the target position
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }

    }
}
