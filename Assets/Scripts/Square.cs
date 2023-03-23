using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private GameObject player;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if (isOnGround)
        {
            Move(player);
        }
    }
}
