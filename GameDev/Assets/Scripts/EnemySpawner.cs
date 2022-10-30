using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject[] theEnemy;
    public Transform spawnPoints;
    public static int HP;
    public static int EnemyAlive;
    public static int Level;
    // Start is called before the first frame update



    void Start()
    {
        
        // Instantiate(enemy1, new Vector3(0, 227, 0), Quaternion.identity);
        // int randSpawPoint = Random.Range(0, spawnPoints.Length);
        // Instantiate(enemy1, spawnPoints[randSpawPoint].position, Quaternion.identity);
    }
    void Spawn(GameObject enemy)
    {
        Instantiate(enemy, spawnPoints.localPosition, Quaternion.identity);

        // GameObject newEnemy = Instantiate(enemy, new Vector3(0, 0, 0), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        if (EnemyAlive == 0)
        {
            GameManager.Level++;
            Spawn(theEnemy[0]);
        }
    }
}
