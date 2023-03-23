using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : Shape
{

    void Update()
    {
        if (isOnGround)
        {
            Move(-this.transform.position + new Vector3(0,0.5f,0));
        }
    }

}
