using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 velocity;

    void Update()
    {
        // Handle player movement (example: using arrow keys)
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Update velocity
        velocity = new Vector3(moveX, 0, moveZ) * 5f; // Modify this as per your speed

        // Move player
        transform.Translate(velocity * Time.deltaTime);
    }
}
