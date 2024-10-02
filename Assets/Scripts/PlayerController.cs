using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    private Vector2 movement;

    [SerializeField]
    private Rigidbody2D player;

    //called once upon game start
	private void Awake()
	{
		player = GetComponent<Rigidbody2D>();   //initalises players rigid body on game start

	}

	// FixedUpdate is called once per frame at a fixed rate
	void FixedUpdate()
    {
       player.velocity = new Vector2 (Input.GetAxis("Horizontal") * moveSpeed, player.velocity.y);  //player left/right movement logic

        /* PLAYER JUMP LOGIC */
        if(Input.GetKeyDown(KeyCode.Space))
        {
            player.velocity = new Vector2(player.velocity.x, moveSpeed);    //player maintains speed when jumping
        }
    }


}
