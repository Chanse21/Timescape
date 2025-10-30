using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Playercontroller : MonoBehaviour
{

    public float movespeed = 5f;
    public Vector3 jump;
    public float jumpForce = 3.0f;
    public bool isGrounded;

    Rigidbody rb;
    public GameObject youWinUI;



    void Start()

    {

        rb = GetComponent<Rigidbody>();
        if (youWinUI != null)
            youWinUI.SetActive(false); // Make sure it's hidden at start

    }



    void FixedUpdate()

    {

        float moveX = 0f;
        float moveZ = 0f;



        if (Input.GetKey("d")) moveX = 1f;

        if (Input.GetKey("a")) moveX = -1f;

        if (Input.GetKey("w")) moveZ = 1f;

        if (Input.GetKey("s")) moveZ = -1f;

        Vector3 move = new Vector3(moveX, 0f, moveZ).normalized * movespeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + move);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

    }



    private void OnCollisionEnter(Collision collision)

    {

        if (collision.gameObject.CompareTag("Right Wall") || collision.gameObject.CompareTag("Left Wall"))

        {

            Destroy(gameObject);

        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }



        if (collision.gameObject.CompareTag("Key"))

        {

            Destroy(collision.gameObject);



            // Stop all walls

            Closingwalls[] walls = FindObjectsOfType<Closingwalls>();

            foreach (Closingwalls wall in walls)

            {

                wall.canMove = false;

            }
            //Shoow "You Win" UI
            if (youWinUI != null)
                youWinUI.SetActive(true);
        }

    }

}