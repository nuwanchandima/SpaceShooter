using UnityEngine;

public class LaserScript : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        if (transform.position.y >= 8.5f)
        {
            Destroy(gameObject); // Destroy the laser if it goes off-screen
        }
    }
}
