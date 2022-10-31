using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static int CHP;
    public static int MaxHP;
    // Start is called before the first frame update
    void Start()
    {
        CHP = EnemySpawner.HP * GameManager.Level;
        MaxHP = CHP;
    }

    // Update is called once per frame
    void Update()
    {
        if(CHP <= 0)
        {
            EnemySpawner.EnemyAlive = 0;
            Game.Increment();
            GameObject.Destroy(gameObject);
        }
    }
}