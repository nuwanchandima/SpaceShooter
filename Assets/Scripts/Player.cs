using UnityEngine;

public class Player : MonoBehaviour
{

  [SerializeField]
  private float _speed = 2.5f;

  private float _xRange = 8.0f, _yRange = 3.0f; //y range for player movement

  void Start()
  {

  } //start

  void Update()
  {
    playerMove();
    playerBound();

    if (Input.GetKeyDown(KeyCode.Space))
    {
      //shooting code here
      Debug.Log("Space key pressed"); //for testing purposes 

    }



  } //update

  private void playerBound() //Player bounds
  {
    if (transform.position.x >= _xRange)
    {
      transform.position = new Vector3(8.0f, transform.position.y, 0);
    } //if

    else if (transform.position.x <= -_xRange)
    {
      transform.position = new Vector3(-8.0f, transform.position.y, 0);
    } //else if


    if (transform.position.y >= _yRange)
    {
      transform.position = new Vector3(transform.position.x, 0f, 0);
    } //else if


    else if (transform.position.y <= -_yRange)
    {
      transform.position = new Vector3(transform.position.x, -3f, 0);
    } //else if

  }

  private void playerMove()
  {
    //local variables
    float _horizontalInput = Input.GetAxis("Horizontal"); //call the input manager and set reference to horizontal axis;
    float _verticalInput = Input.GetAxis("Vertical");


    //horizontal movement
    transform.Translate(Vector3.right * _speed * Time.deltaTime * _horizontalInput);

    //vertical movement
    transform.Translate(Vector3.up * _speed * Time.deltaTime * _verticalInput);
  } //playerMove


} //class
