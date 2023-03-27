using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 10f;
    public float jumpMult = 500f;
    private GameObject player;
    private Shape playerShape;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerShape = player.GetComponent<Shape>();
        playerRb = player.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (playerShape.IsOnGround)
        {
            float verticalInput = Input.GetAxis("Vertical");
            float hrizontalInput = Input.GetAxis("Horizontal");
            playerRb.AddForce(transform.forward * speed * hrizontalInput);
            playerRb.AddForce(transform.right * speed * -verticalInput);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerRb.AddForce(transform.up * jumpMult);
                playerShape.IsOnGround = false;
            }
        }
    }
}
