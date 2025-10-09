using UnityEngine;
using System.Collection;
using System.Collection.Generic;
using UnityEngine.SceneManagement;// add scene managment name space
using TMPro;// add the TMPro Namspace
public class PlayerControler_2D : MonoBehaviour
{
    //value types
    [Header("Player Settings")]
    public float moveSpeed;// how fast the player moves side to side
    public float jumpForce; //how high the player jumps
    public bool isGrounded; // is the player grounded, true or false
    public int bottomBound = -4; // store bottom boundry value (see if you fallen off the platform)
    [Header("Score")]
    public int score;// store the score value



    //Reference types
    public Rigidbody2D rig; //rigid boday reference
    public TextMeshProUGUI scoreText; //text UI reference


    // increase the score and update the score text UI
    public void AddScore(int amount)
    {
        //Add to score
        score += amount;
        //update score text ui
        score.Text = "score: " + score;
    }


    void FixedUpdate()
    {
        //gather inputes
        float moveInput = Input.GetAxisRaw("Horizontal");
        //make the player move side to side
        rig.velocity = new Vectore2(moveInput * moveSpeed, rig.velocity);
    }



    // Update is called once per frame
    void Update()
    {
        // if we press the jup button and we are grounded, then jump
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            isGrounded = false;
            rig.AddForce(vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        // if we fall below bottom bound(-4) on the y axis then game over is triggerd
        if (transform.position.y < bottomBound)
        {
            GameOver();
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        //if player is touching the ground set isGrounded to true.
        if (collision.GetContact(0).normal == Vector2.up)
        {
            isGrounded = true;
        }
    }
    //called when hit by and enemy or when we fall of level
    public void GameOver()
    {
        sceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    
}
