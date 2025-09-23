using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MoveUp : MonoBehaviour
{
    public float speed = 3.0f;
    public float upperBound = 15.0f;
    public ScoreManager scoreManager; //Referance the scoremanager
    public Balloon balloon;// reference the balloon script to get the score amount

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime); // Move the balloon at a fixed rate of speed up on the Y axis.

        if (transform.position.y >= upperBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive);//reduces the score for allowing the balloon to go to far up (off the screen)
            Destroy(gameObject);// destroys balloons that leave the top of the screen
        }
    }
}
