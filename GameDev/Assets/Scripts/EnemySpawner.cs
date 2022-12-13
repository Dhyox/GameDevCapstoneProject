using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject[] theEnemy;
    public Transform spawnPoints;
    public Transform Parent;
    public static int HP;
    public static int EnemyAlive;
    // Start is called before the first frame update

    void Start()
    {
        Spawn(theEnemy[Random.Range(0,theEnemy.Length)]);
        // Instantiate(enemy1, new Vector3(0, 227, 0), Quaternion.identity);
        // int randSpawPoint = Random.Range(0, spawnPoints.Length);
        // Instantiate(enemy1, spawnPoints[randSpawPoint].position, Quaternion.identity);
    }
    void Spawn(GameObject enemy)
    {
        Instantiate(enemy, spawnPoints.position, Quaternion.identity, Parent);
        EnemyAlive = 1;
        // GameObject newEnemy = Instantiate(enemy, new Vector3(0, 0, 0), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        if (EnemyAlive == 0)        //Cek musuh mati / ngga
        {
            GameManager.Level++;        //Level enemy nambah
            Spawn(theEnemy[Random.Range(0, theEnemy.Length)]);
        }
    }
}
