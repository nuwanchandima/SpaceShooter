using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10f; //speed of the laser
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime); //move the laser up at a speed of 10 units per second

        if(transform.position.y >= 5.0f) //if the laser goes off the screen
        {
            Destroy(gameObject); //destroy the laser
        } //if
    }
}
