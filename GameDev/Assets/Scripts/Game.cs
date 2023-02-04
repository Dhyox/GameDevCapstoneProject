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

    public Text critrate;
    public Text CritRatePrice;
    public Text CritRatePlus;

    public Text enemyName;

    public Text bossTag;

    public Text test1;
    public float displayTime = 2.0f;
    public RectTransform container;

    public Button button; //ClickerArea
    public Text CritText;
    public float CritRate = GameManager.critrate;

    private void Start()
    {
        test1.gameObject.SetActive(false);
        button.onClick.AddListener(OnButtonClick);
        CritText.gameObject.SetActive(false);
    }

    //Buat display damage
    public void OnButtonClick()
    {
        //Damage crit
        float randomValue = Random.value;
        if(randomValue <= GameManager.critrate)
        {
            Enemy.CHP -= GameManager.crit;
            CritText.gameObject.SetActive(true);
            Invoke("HideCrit", 0.4f);
        }
        //Damage biasa
        test1.gameObject.SetActive(true);
        test1.rectTransform.anchoredPosition = new Vector2(
            Random.Range(-container.sizeDelta.x / 2, container.sizeDelta.x / 2),
            Random.Range(-container.sizeDelta.y / 2, container.sizeDelta.y / 2)
        );
        Invoke("HideText", displayTime);
    }
    public void HideCrit()
    {
        CritText.gameObject.SetActive(false);
    }
    public void HideText()
    {
        test1.gameObject.SetActive(false);
    }

    //Buat display nama musuh
    public void DisplayName(string Name)
    {
        enemyName.text = Name;
    }

    //Drop coin enemy
    public static void Increment()
    {
        GameManager.coin += (GameManager.Level / 2);
        PlayerPrefs.SetInt("coin", GameManager.coin);
    }

    //Buat nge damage musuh
    public void Hit()
    {
        Enemy.CHP -= GameManager.multiplier;
        // Debug.Log("HIT");
    }

    //Buat Shop
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
        if (num == 2 && GameManager.coin >= GameManager.BuyPrice2)
        {
            GameManager.critrate += (GameManager.nextcritrate - GameManager.critrate);
            GameManager.coin -= GameManager.BuyPrice2;
            PlayerPrefs.SetInt("coin", GameManager.coin);
            PlayerPrefs.SetFloat("critrate", GameManager.critrate);
            GameManager.BuyPrice2 = GameManager.OldBuyPrice2 + (GameManager.OldBuyPrice2 / 2);
            GameManager.OldBuyPrice2 = GameManager.BuyPrice2;
            GameManager.nextcritrate = GameManager.critrate + 0.005f; 
        }
    }

    //Buat update text ui
    public void Update()
    {
        textCoin.text = "" + GameManager.coin;
        //textMulti.text = "Damage: " + GameManager.multiplier + "/Hit";
        textMulti.text = "" + GameManager.multiplier;
        textLevel.text = "Level: " + GameManager.Level;
        HPBar.value = (float)Enemy.CHP / (float)Enemy.MaxHP;

        BaseAtkPrice.text = "$"+ GameManager.BuyPrice1;
        BaseAtkPlus.text = "+" + (GameManager.NextBaseAtk - GameManager.multiplier);

        CritRatePrice.text = "$" + GameManager.BuyPrice2;
        CritRatePlus.text = "+" + 0.005f;
        critrate.text = "" + Mathf.Round(GameManager.critrate * 1000f)/1000f;

        CritText.text = "" + GameManager.crit;
        if(GameManager.Level % 10 == 0)
        {
            bossTag.gameObject.SetActive(true);
        }
        else
        {
            bossTag.gameObject.SetActive(false);
        }
    }
}