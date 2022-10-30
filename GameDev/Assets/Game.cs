using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Text textCoin;
    public Text textMulti;

    public void Increment()
    {
        GameManager.coin += GameManager.multiplier;
    }

    public void Buy(int num)
    {
        if (num == 1 && GameManager.coin >= 10)
        {
            GameManager.multiplier += 1;
            GameManager.coin -= 10;
        }
        if (num == 2 && GameManager.coin >= 100)
        {
            GameManager.multiplier += 10;
            GameManager.coin -= 100;
        }
        if (num == 3 && GameManager.coin >= 1000)
        {
            GameManager.multiplier += 100;
            GameManager.coin -= 1000;
        }
    }

    public void Update()
    {
        textCoin.text = "Coins: " + GameManager.coin;
        textMulti.text = "Multiplier: " + GameManager.multiplier + "x";        
    }
}