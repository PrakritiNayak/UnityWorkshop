using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yiting : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float jump;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * jump;
        }
    }
}
