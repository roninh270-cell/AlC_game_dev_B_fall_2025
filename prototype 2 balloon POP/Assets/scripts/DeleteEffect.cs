using UnityEngine;

public class DeleteEffect : MonoBehaviour
{

    public int timer = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, timer);// Timer count down before destroying gameobject
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
