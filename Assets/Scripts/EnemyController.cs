using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Reference to the player's health script.
    public PlayerHealth playerHealthScript;

    // Damage value to subtract from the player's health.
    public float damageValue;

    // Start is called before the first frame update
    void Start()
    {
        // Find the GameObject with the tag "Player" and get the PlayerHealth component.
        playerHealthScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    // OnTriggerEnter is called when another collider enters this object's trigger collider.
    public void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the tag "Player".
        if (other.tag == "Player")
        {
            // Subtract damageValue from the player's current health.
            playerHealthScript.playerCurrentHealth -= damageValue;

            // Log the player's current health to the console for debugging.
            Debug.Log("The player's current health is " + playerHealthScript.playerCurrentHealth);
        }
        else
        {
            // If the colliding object is not the player, log an error message for debugging.
            Debug.LogError("NOT THE PLAYER");
        }
    }
}
