using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private float _speed = 7.5f; // Speed of the player
    private float _xRangeRight = 8.0f, _xRangeLeft = -8.0f; // X-axis range for player movement
    private float _yRangeTop = 0f, _yRangeBottom = -3.5f; // Y-axis range for player movement

    [SerializeField]
    private GameObject _laserPrefab; // Prefab for the laser object 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement(); // Call the PlayerMovement method every frame
        PlayerBound(); // Call the PlayerBound method every frame
        playerShoot(); // Call the playerShoot method every frame


    }

    private void PlayerMovement()
    {
        // Get the horizontal and vertical input from the user (A/D or Left/Right Arrow keys for horizontal, W/S or Up/Down Arrow keys for vertical)
        float _horizontalInput = Input.GetAxis("Horizontal"); // Get the horizontal input (A/D or Left/Right Arrow keys)
        float _verticalInput = Input.GetAxis("Vertical"); // Get the vertical input (W/S or Up/Down Arrow keys)
        transform.Translate(Vector3.right * Time.deltaTime * _speed * _horizontalInput); // Move the player to the right at a speed of 5 units per second
        transform.Translate(Vector3.up * Time.deltaTime * _speed * _verticalInput); // Move the player forward at a speed of 5 units per second
    }

    private void PlayerBound()
    {
        Vector3 currentPosition = transform.position;

        // Clamp X position
        if (currentPosition.x >= _xRangeRight)
        {
            currentPosition.x = _xRangeRight; // Set to right boundary
        }
        if (currentPosition.x <= _xRangeLeft)
        {
            currentPosition.x = _xRangeLeft; // Set to left boundary
        }

        // Clamp Y position
        if (currentPosition.y >= _yRangeTop)
        {
            currentPosition.y = _yRangeTop; // Set to top boundary
        }
        if (currentPosition.y <= _yRangeBottom)
        {
            currentPosition.y = _yRangeBottom; // Set to bottom boundary
        }

        // Apply the clamped position
        transform.position = currentPosition;
    }

    private void playerShoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Call the Fire method when the space key is pressed
            print("Space key pressed"); // For testing purposes
            Vector3 currentPosition = transform.position;
            currentPosition.y += 1.465f; // Adjust the Y position to spawn the laser slightly above the player
            Instantiate(_laserPrefab, currentPosition, Quaternion.identity); // Create a new laser object at the player's position
        }
    }
} // End of PlayerScript class
// End of PlayerScript.cs

