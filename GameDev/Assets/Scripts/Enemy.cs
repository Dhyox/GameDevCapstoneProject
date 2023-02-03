using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static int CHP;
    public static int MaxHP;
    private Animator animate;
    public string Name;
    
    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.Level % 10 == 0)
        {
            CHP = (EnemySpawner.HP * 5) + GameManager.Level - 1;
            MaxHP = CHP;
        }
        else
        {
            CHP = EnemySpawner.HP + GameManager.Level - 1;
            MaxHP = CHP;
        }

        PlayerPrefs.SetInt(Name, 1); //Ini rencananya buat ngecek udah pernah ketemu musuhnya ato belom, blm selesai dibuat
        animate= gameObject.GetComponent<Animator>();
        //CHP = EnemySpawner.HP + GameManager.Level-1;
        //MaxHP = CHP;
    }

    // Update is called once per frame
    void Update()
    {
        if(CHP <= 0)                //Ngecek musuh mati ato ngga
        {
            EnemySpawner.EnemyAlive = 0;
            Game.Increment();
            GameObject.Destroy(gameObject);
        }
    }
}