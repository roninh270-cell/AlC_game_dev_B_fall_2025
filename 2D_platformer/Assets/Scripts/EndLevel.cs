using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class EndLevel : MonoBehaviour
{
    public bool FinalLevel;
    public string nectLevelName;

    private void OnTriggerEnder2D(Collider2D collision)
    {
        // if this is final level play victory screen
        if (FinalLevel == true)
        {
            SceneManager.LoadScene(0);
        }

        // otherwise load up the next level
        else
        {
            SceneManager.LoadScene(nectLevelName);
        }
    }
}