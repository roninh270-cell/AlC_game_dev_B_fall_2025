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
        transform.position = Vector3.MoveTwowards(transform.position, moveSpeed * Time.deltaTime);

        //are we at the target position
        if (transform.position == targetPos)
        {
            //is our target pos our start pos? if so, set it to be the other one.
            if (targetPos == startPos)
            {
                targetPos = startPos + moveOffset;
            }
        }
        else
        {
            targetPos = startPos;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))//did the player hit us?
        {
            collision.GetCompounent<PlayerController2D>().GameOVer();
        }
    }
    private void OnDrawnGizmos()
    {
        vector3 from;
        vector2 to;

        if (Application.isPlaying)
        {
            from = startPos;

        }
        else
        {
            from = transform.position;
        }
        to = from + moveOffset;

        OnDrawnGizmos.color = Color.red;
        
    }

}    