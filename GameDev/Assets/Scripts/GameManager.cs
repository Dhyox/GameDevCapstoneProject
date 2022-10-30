using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int coin;
    public static int multiplier;
    // Start is called before the first frame update
    void Start()
    {
        multiplier = PlayerPrefs.GetInt("multiplier",1);
        coin = PlayerPrefs.GetInt("coin", 0);
    }

    public void ResetProgress()
    {
        PlayerPrefs.DeleteAll();
    }

}