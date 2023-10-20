using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardPlayerMovement : MonoBehaviour
{
    public GameObject playerGameObject;             //a public reference for our player object

    public float turnSpeed;                         //creates a floating point variable to control turn speed
    public float movementSpeed;                     //creates a floating point variable to control movement speed


    // Update is called once per frame  
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))                                                              //when up key os pressed...
        {
            playerGameObject.transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);     //this object move forward
        }

        if (Input.GetKey(KeyCode.DownArrow))                                                            //when down key is pressed...
        {
            playerGameObject.transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);        //this object move back
        }

        if (Input.GetKey(KeyCode.LeftArrow))                                                            //when left key is pressed...
        {
            playerGameObject.transform.Rotate(Vector3.up, -turnSpeed);                                  //rotate left
        }

        if (Input.GetKey(KeyCode.RightArrow))                                                           //when right key is pressed...
        {
            playerGameObject.transform.Rotate(Vector3.up, turnSpeed);                                   //rotate to the right
        }        
    }
}
