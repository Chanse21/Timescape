using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Playercontroller : MonoBehaviour
{
    public float movespeed = 5f;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

        if (Input.GetKey("d"))
        {
            newPosition += Vector3.right * movespeed * Time.deltaTime;
        }

        if (Input.GetKey("a"))
        {
            newPosition += Vector3.left * movespeed * Time.deltaTime;
        }

        if (Input.GetKey("w"))
        {
            newPosition += Vector3.forward * movespeed * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            newPosition += Vector3.back * movespeed * Time.deltaTime;
        }
        transform.position = newPosition;
    }
}