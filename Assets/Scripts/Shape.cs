using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public Rigidbody shapeRb;
    public float speed = 0.0001f;
    public float jumpMult = 0.05f;
    private bool isOnGround = false;

    void Start()
    {
        shapeRb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }
    //encapsulation
    public bool IsOnGround
    {
        get
        {
            return isOnGround;
        }
        set
        {
            isOnGround = value;
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
    public virtual void Jump()
    {
        shapeRb.AddForce(Vector3.up * jumpMult);
        IsOnGround = false;
    }

    public virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsOnGround = true;
        }

    }
}
