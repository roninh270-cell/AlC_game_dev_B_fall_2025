using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class EndLevel : MonoBehaviour// add the scene managemnt name space
{
    public bool FinalLevel;
    public string nextLevelName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {


            // if this is final level play victory screen
            if (FinalLevel == true)
            {
                SceneManager.LoadScene(0);
            }

            // otherwise load up the next level
            else
            {
                SceneManager.LoadScene(nextLevelName);
            }
        }
    }
}