using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; // How many clicks till the ballon pops

    public float scaleToIncrease = 0.15f; // scale incresed each time the ballon is clicked

    public int scoreToGive; // score given for the popped ballon

    private ScoreManager scoreManager; // A variable to reference the scoreManger

    public GameObject popEffect; //Refrance pop effect particle system

    void OnMouseDown()
    {


        //reduce clicks by one
        clickToPop -= 1;
        /// <summary>
        /// increase balloon size
        transform.localScale += Vector3.one * scaleToIncrease;
        /// check to see if the balloon has popped
        if (clickToPop == 0);
        {
            Destroy(gameObject);
        }
    } 
// scoreManager.IncreaseScoreText()
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
