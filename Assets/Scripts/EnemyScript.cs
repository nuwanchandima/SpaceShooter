using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f; // Speed of the enemy
    private float _xRangeRight = 7.5f, _xRangeLeft = -7.5f; // X-axis range for enemy movement
    private float _yRangeTop = 8.5f, _yRangeBottom = -8.5f; // Y-axis range for enemy respawn
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime); // Move the enemy down at a speed of 5 units per second

        if (transform.position.y <= _yRangeBottom) // If the enemy goes off the screen
        {
            transform.position = new Vector3(Random.Range(_xRangeRight, _xRangeLeft), _yRangeTop, 0); // Reset the enemy's position to the top of the screen at a random x position
        }
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        print(target.name); // For testing purposes
        Debug.Log("Collided!"); // For testing purposes
        //target.gameObject.GetComponent<SpriteRenderer>().material.color = Color.black; // Change the color of the laser to black when it collides with the enemy
        Destroy(gameObject); // Destroy the enemy when it collides with the laser
        Destroy(target.gameObject); // Destroy the laser when it collides with the enemy
    }
}
