using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    private Rigidbody shapeRb;
    public float speed = 0.1f;
    public bool isOnGround = false;

    void Start()
    {
        shapeRb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    public bool IsOnGround
    {
        get
        {
            return isOnGround;
        }
        set
        {
            isOnGround = IsOnGround;
        }
    }

    //polymorphism & abstraction
    public virtual void Move(Vector3 location)
    {
        shapeRb.AddForce(location * speed);
    }
    public virtual void Move(GameObject gameObject)
    {
        shapeRb.AddForce((gameObject.transform.position - transform.position) * speed);
    }

    public virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

    }
}
