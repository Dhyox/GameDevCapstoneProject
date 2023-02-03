using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Text textCoin;
    public Text textMulti;
    public Text textLevel;
    public Slider HPBar;
    public Text BaseAtkPrice;
    public Text BaseAtkPlus;
    public Text enemyName;

    public Text test1;
    public float displayTime = 2.0f;
    public RectTransform container;

    private void Start()
    {
        test1.gameObject.SetActive(false);
    }

    public void OnButtonClick()
    {
        test1.gameObject.SetActive(true);
        test1.rectTransform.anchoredPosition = new Vector2(
            Random.Range(-container.sizeDelta.x / 2, container.sizeDelta.x / 2),
            Random.Range(-container.sizeDelta.y / 2, container.sizeDelta.y / 2)
        );
        Invoke("HideText", displayTime);
    }

    public void HideText()
    {
        test1.gameObject.SetActive(false);
    }

    public void DisplayName(string Name)
    {
        enemyName.text = Name;
    }
    public static void Increment() //Drop Coin Enemy
    {
        GameManager.coin += (GameManager.Level / 2);
        PlayerPrefs.SetInt("coin", GameManager.coin);
    }

    public void Hit()
    {
        Enemy.CHP -= GameManager.multiplier;
        // Debug.Log("HIT");
    }

    public void Buy(int num)
    {
        if (num == 1 && GameManager.coin >= GameManager.BuyPrice1)
        {
            GameManager.multiplier += (GameManager.NextBaseAtk-GameManager.multiplier);
            GameManager.coin -= GameManager.BuyPrice1;
            PlayerPrefs.SetInt("coin", GameManager.coin);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
            GameManager.BuyPrice1 = GameManager.OldBuyPrice1 + GameManager.NextBaseAtk;
            GameManager.OldBuyPrice1 = GameManager.BuyPrice1;
            GameManager.NextBaseAtk = GameManager.multiplier+2;
        }
        if (num == 2 && GameManager.coin >= 100)
        {
            GameManager.multiplier += 10;
            GameManager.coin -= 100;
            PlayerPrefs.SetInt("coin", GameManager.coin);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
    }

    public void Update()
    {
        textCoin.text = "" + GameManager.coin;
        //textMulti.text = "Damage: " + GameManager.multiplier + "/Hit";
        textMulti.text = "" + GameManager.multiplier;
        textLevel.text = "Level: " + GameManager.Level;
        HPBar.value = (float)Enemy.CHP / (float)Enemy.MaxHP;
        BaseAtkPrice.text = "$"+ GameManager.BuyPrice1;
        BaseAtkPlus.text = "+" + (GameManager.NextBaseAtk-GameManager.multiplier);
        
    }
}