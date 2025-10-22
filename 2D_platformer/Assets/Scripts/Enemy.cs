using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed;//speed
    public Vector3 moveOffset;//Enemy direction
    private Vector3 startPos;//start position
    private Vector3 targetPos;// target position



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        targetPos = startPos;

    }

    // Update is called once per frame
    void Update()
    {
        // move to the target
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);

        //are we at the target position
        if (transform.position == targetPos)
        {
            //is our target pos our start pos? if so, set it to be the other one.
            if (targetPos == startPos)
            {
                targetPos = startPos + moveOffset;
            }


            else
            {
                targetPos = startPos;
            }
        }
    
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))//did the player hit us?
        {
            collision.GetComponent<PlayerController_2D>().GameOver();
        }
    }
    private void OnDrawnGizmos()
    {
        Vector3 from;
        Vector2 to;

        if (Application.isPlaying)
        {
            from = startPos;

        }
        else
        {
            from = transform.position;
        }
        to = from + moveOffset;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(from, to);
        Gizmos.DrawWireSphere(to, 0.2f);
        Gizmos.DrawWireSphere(from, 0.2f);
    }

}    