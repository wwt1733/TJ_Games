using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public TMP_Text healthText;

    public void Start()
    {
        healthText.text = "HP:" + StatsManager.instance.currentHealth + "/" + StatsManager.instance.maxHealth;
    }

    public void ChangeHealth(int amount)
    {

        StatsManager.instance.currentHealth += amount;
        healthText.text = "HP:" + StatsManager.instance.currentHealth + "/" + StatsManager.instance.maxHealth;
        if (StatsManager.instance.currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
