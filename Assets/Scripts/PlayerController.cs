using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float Speed = 5f; // Public variable to adjust player speed in Inspector

    // Update is called once per frame
    void FixedUpdate()
	{
        // Get input from player
        float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Move the player
        GetComponent<Rigidbody>().velocity = movement * Speed;
	}
}
