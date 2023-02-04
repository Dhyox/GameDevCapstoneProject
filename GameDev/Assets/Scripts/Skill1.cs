using UnityEngine;
using UnityEngine.UI;

public class Skill1 : MonoBehaviour
{
    public Image imageButton;
    public Text cooldownText;
    public int skillDamage = 10;
    public float cooldownDuration = 5f;

    private bool isOnCooldown = false;
    private float remainingCooldown = 0f;

    public Button button;
    public int reqLvl = 10;

    private void Update()
    {
        if(GameManager.Level >= reqLvl)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }

        if (isOnCooldown)
        {
            remainingCooldown -= Time.deltaTime;
            cooldownText.text = remainingCooldown.ToString("0");

            if (remainingCooldown <= 0)
            {
                isOnCooldown = false;
                imageButton.color = Color.white;
                cooldownText.text = "";
            }
        }
    }

    public void OnButtonClicked()
    {
        if (!isOnCooldown)
        {
            isOnCooldown = true;
            remainingCooldown = cooldownDuration;
            imageButton.color = new Color(0.5f, 0.5f, 0.5f, 1f);
            Enemy.CHP -= (GameManager.multiplier * skillDamage);
        }
    }
}
