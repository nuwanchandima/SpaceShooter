using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Start the coroutine to print a message after 5 seconds
        StartCoroutine(SpawnEnemyRoutine());

        //old version
        // InvokeRepeating("PrintMessage", 2f, 2f);
    } // Start

    // Update is called once per frame
    void Update()
    {

    } // Update

    private IEnumerator SpawnEnemyRoutine()
    {
        yield return new WaitForSeconds(Random.Range(2.5f, 4.5f));
        print("Five seconds have passed!");
        Instantiate(_enemyPrefab, new Vector3(Random.Range(-8f, 8f), 8f, 0f), Quaternion.identity);

        StartCoroutine(SpawnEnemyRoutine());
    }// SpawnEnemyRoutine

    // private PrintMessage(){
    //     print("hello invoke")
    // }
} // SpawnManager
