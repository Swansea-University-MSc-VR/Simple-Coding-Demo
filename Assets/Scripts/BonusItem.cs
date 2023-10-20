using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusItem : MonoBehaviour
{
    public ScoreHolder scoreHolder;
    public float bonusAmount;

    // Start is called before the first frame update
    void Start()
    {
        scoreHolder = GameObject.FindGameObjectWithTag("Player").GetComponent<ScoreHolder>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            scoreHolder.totalScore = scoreHolder.totalScore + bonusAmount;
            Debug.Log("Plaer's current score is: " + scoreHolder.totalScore);
        }
    }
}
