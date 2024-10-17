using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  
    private Rigidbody2D rb;
    private float moveInput;
    private float moveSpeed = 10f;

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();   //initalises players rigid body 
	}

	// FixedUpdate is called once per frame at a fixed rate
	void FixedUpdate()
    {
		//player movement logic
		moveInput = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2 (moveInput * moveSpeed, rb.velocity.y);  
  
    }


}
