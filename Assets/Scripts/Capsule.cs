using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape //inheritance
{
    private GameObject player;
    void Start()
    {
        shapeRb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (IsOnGround)
        {
            Jump();
        }
    }
}
