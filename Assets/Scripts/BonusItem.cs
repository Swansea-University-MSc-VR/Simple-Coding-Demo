using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusItem : MonoBehaviour
{
    // Reference to the ScoreHolder script to access the totalScore variable.
    public ScoreHolder scoreHolder;

    // The amount of bonus to be added to the player's score when the item is collected.
    public float bonusAmount;

    // Start is called before the first frame update
    void Start()
    {
        // Find and assign the ScoreHolder component of the GameObject with the "Player" tag.
        scoreHolder = GameObject.FindGameObjectWithTag("Player").GetComponent<ScoreHolder>();
    }

    // OnTriggerEnter is called when the Collider other enters the trigger collider of this GameObject.
    public void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the tag "Player".
        if (other.tag == "Player")
        {
            // Add the bonusAmount to the player's total score.
            scoreHolder.totalScore += bonusAmount;

            // Log the player's updated score to the console for debugging purposes.
            Debug.Log("Player's current score is: " + scoreHolder.totalScore);
        }
    }
}
