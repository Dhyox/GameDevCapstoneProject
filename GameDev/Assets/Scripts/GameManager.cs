using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int coin;
    public static int multiplier; //Base attack dmg
    public static int NextBaseAtk;
    public static int Level;      //Level Enemy
    public static int PlayerLvl;
    public static int BuyPrice1;
    public static int OldBuyPrice1;
    // Start is called before the first frame update
    void Start()
    {
        multiplier = PlayerPrefs.GetInt("multiplier",1);
        NextBaseAtk = multiplier + 1;
        coin = PlayerPrefs.GetInt("coin", 0);
        Level = PlayerPrefs.GetInt("Level", 1);
        PlayerLvl = PlayerPrefs.GetInt("PlayerLvl", 1);
        BuyPrice1 = PlayerPrefs.GetInt("BuyPrice1", 2);
        OldBuyPrice1 = BuyPrice1;
        EnemySpawner.HP = PlayerPrefs.GetInt("HP", 10);
        EnemySpawner.EnemyAlive = 1;
    }

    public void ResetProgress()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void Update()
    {
        
    }

}