using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public float moveSpeed;
    public float jumpForce;

    private Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            playerRb.AddForce(new Vector2(playerRb.velocity.x, jumpForce));
        }
    }

	private void FixedUpdate()
	{
		playerRb.MovePosition(playerRb.position + movement * moveSpeed * Time.deltaTime);
	}
}
