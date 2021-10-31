using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float score;

    void Update()
    {
        //Setting playerprefs every fame will cause performance issues. Instead do it in add.
        //PlayerPrefs.SetFloat("score", score);
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Add(float score)
    {
        score += score;
        PlayerPrefs.SetFloat("score", score);
    }
}
