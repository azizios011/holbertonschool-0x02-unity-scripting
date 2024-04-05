using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float Speed = 5f; // Public variable to adjust player speed in Inspector
    private int score = 0;
    public int health = 5;

    void OnTriggerEnter(Collider other)
    {
        // Check if the collided object is tagged as "Pickup".
        if (other.CompareTag("Pickup"))
        {
            // Increment score.
            score++;

            // Log the updated score to the console
            Debug.Log("Score: " + score);

            // Disable or destroy the coin object
            // You can choose either option based on your requirements
            // For example, to disable the coin:
            other.gameObject.SetActive(false);
            // Or to destroy the coin:
            // Destroy(other.gameObject);
        }
        // Check if the collided object is tagged as "Trap".
        else if (other.CompareTag("Trap"))
        {
            // Decrement health.
            health--;

            // Log the updated health to the console.
            Debug.Log("Health: " + health);
            // Also we can add logic here to handle player death if health reaches 0
        }
        else if (other.CompareTag("Goal"))
        {
            // Display "You win!" message to the console.
            Debug.Log("You win!");
        }
    }
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
