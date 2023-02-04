using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int coin;
    public static int multiplier; //Base attack dmg
    public static int crit; //CRIT DMG
    public static float critrate;
    public static float nextcritrate;
    public static int NextBaseAtk;
    public static int Level;      //Level Enemy
    public static int PlayerLvl;
    
    public static int BuyPrice1;
    public static int OldBuyPrice1;

    public static int BuyPrice2;
    public static int OldBuyPrice2;

    // Start is called before the first frame update
    void Start()
    {
        multiplier = PlayerPrefs.GetInt("multiplier",1);
        crit = PlayerPrefs.GetInt("crit", multiplier * 5);
        critrate = PlayerPrefs.GetFloat("critrate", 0.005f);
        NextBaseAtk = multiplier + 1;
        nextcritrate = critrate + 0.005f;
        coin = PlayerPrefs.GetInt("coin", 0);
        Level = PlayerPrefs.GetInt("Level", 1);
        PlayerLvl = PlayerPrefs.GetInt("PlayerLvl", 1);

        BuyPrice1 = PlayerPrefs.GetInt("BuyPrice1", 2);
        OldBuyPrice1 = BuyPrice1;

        BuyPrice2 = PlayerPrefs.GetInt("BuyPrice2", 5);
        OldBuyPrice2 = BuyPrice2;

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