using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f; // Speed of the enemy
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime); // Move the enemy down at a speed of 5 units per second

        if (transform.position.y < -7.5f) // If the enemy goes off the screen
        {
            transform.position = new Vector3(Random.Range(-8f, 8f), 7.5f, 0); // Reset the enemy's position to the top of the screen at a random x position
        }
    }
}
