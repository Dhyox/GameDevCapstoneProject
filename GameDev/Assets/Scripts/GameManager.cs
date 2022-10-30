using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int coin;
    public static int multiplier;
    public static int Level;
    // Start is called before the first frame update
    void Start()
    {
        multiplier = PlayerPrefs.GetInt("multiplier",1);
        coin = PlayerPrefs.GetInt("coin", 0);
        Level = PlayerPrefs.GetInt("Level", 1);
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