using UnityEngine;

public class Coin : MonoBehaviour
{
    public int scoreToGive; // how many paints do we give
    private float startYPos; // coin start position on the y line
    public float bobHeight; // how high the coin will bob
    public float bobSpeed; // how fast the conin will bob


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //check to see if we hit the player
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerController_2D>().AddScore(scoreToGive);

            Destroy(gameObject);
        }
    }


    void Start()
    {
        startYPos = transform.position.y; //set the start position to the current position
    }

    // Update is called once per frame
    void Update()
    {
        //move coin up and down. aka bob
        float newY = startYPos + (Mathf.Sin(Time.time * bobSpeed) * bobHeight);
        transform.position = new Vector3(transform.position.x, newY, 0);
    }
}
