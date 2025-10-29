using UnityEngine;
using UnityEngine.SceneManagement;

public class Keyscript : MonoBehaviour
{

    public float radius = 5f;       // Radius of the circle

    public float speed = 2f;        // How fast it goes around

    public Vector3 center = Vector3.zero; // Center point of the circle



    private float angle = 0f;



    void Update()

    {

        // Increase the angle over time

        angle += speed * Time.deltaTime;



        // Calculate the new X and Z positions

        float x = Mathf.Cos(angle) * radius;

        float z = Mathf.Sin(angle) * radius;



        // Apply the new position (you can change axes if needed)

        transform.position = new Vector3(center.x + x, transform.position.y, center.z + z);

    }

}

