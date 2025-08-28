using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; // the speed of the controller
    public float rotSpeed; // the rotation speed of the controller

    public float hInput;//Store vales for horizontal movement 
    public float vInput;//Store vales for vertical movement


    // This runs when game starts

    void Start()
    {
       
    }
    
    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, hInput * rotSpeed * Time.deltaTime); //makes vehical rotate side to side
        transform.Translate(Vector3.forward * vInput * speed * Time.deltaTime); // moves vehical forward and backwards
    }
}
