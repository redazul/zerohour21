using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float score;
    public Canvas PauseMenu;
    private bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("score", score);

        if (Input.GetKeyDown(KeyCode.P) && !isPaused)
        {
            PauseMenu.gameObject.SetActive(true);
            isPaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.P) && isPaused)
        {
            PauseMenu.gameObject.SetActive(false);
            isPaused = false;
        }
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Add(float score)
    {
        score += score;
    }
}
