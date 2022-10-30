using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static int CHP = EnemySpawner.HP * GameManager.Level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CHP == 0)
        {
            EnemySpawner.EnemyAlive = 0;
            GameObject.Destroy(gameObject);
        }
    }
}