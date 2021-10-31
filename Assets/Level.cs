using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public float speed;
    public Canvas PauseMenu;
    private bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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

        transform.Translate(Vector3.up * Time.deltaTime * speed);
        speed += 0.01f * Time.deltaTime;
    }
}
