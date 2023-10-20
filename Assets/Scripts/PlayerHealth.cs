using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    public float playerMaxHealth;               //creates a variable to carry the player max health value
    public float playerCurrentHealth;           //creates a variable to carry the players current health value

    public TMP_Text healthText;

    public Slider healthSlider;
    public Image healthSliderFill;

    // Start is called before the first frame update
    void Start()
    {
        if(healthSlider == null)
        {
            Debug.LogError("HEalth SLider not set!!");
        }

        healthSlider.maxValue = playerMaxHealth;

        playerCurrentHealth = playerMaxHealth;                                      //set the player current health to equal the max health value
        Debug.Log("The starting health of the player is: " + playerCurrentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + playerCurrentHealth;

        healthSlider.value = playerCurrentHealth;

        if (playerCurrentHealth >= (playerMaxHealth / 100) * 50)
        {
            healthText.color = Color.green;
            healthSliderFill.color = Color.green;
        }

        else if (playerCurrentHealth >= (playerMaxHealth / 100) * 30 && playerCurrentHealth <= (playerMaxHealth / 100) * 50)
        {
            healthText.color = Color.yellow;
            healthSliderFill.color = Color.yellow;
        }

        else if (playerCurrentHealth >= (playerMaxHealth / 100) * 0 && playerCurrentHealth <= (playerMaxHealth / 100) * 30)
        {
            healthText.color = Color.red;
            healthSliderFill.color = Color.red;
        }

        if (playerCurrentHealth <= 0)                                                       //if the player health is less than or equal to zero....
        {
            Debug.LogError("The player has reached " + playerCurrentHealth + " health and has died!");   //debug log message the player hrealth value
        }
    }

}
