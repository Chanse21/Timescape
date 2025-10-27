using UnityEngine;

public class Closingwalls : MonoBehaviour
{
    public Vector3 targetPosition; // The final position the wall will move to
    public float speed = 1f;       // Speed of wall movement

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position; // Store the starting position
    }

    void Update()
    {
        // Move the wall towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Optional: Check if the wall has reached its target and stop movement
        if (transform.position == targetPosition)
        {
            // For example, you could disable this script or trigger an event
            // enabled = false; 
        }
    }
}
