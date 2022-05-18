using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject resume_button;
    [SerializeField] private GameObject quit_button;

    // Start is called before the first frame update
    void Start()
    {
        resume_button.SetActive(false);
        quit_button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0; //pause game
            resume_button.SetActive(true);
            quit_button.SetActive(true);
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        resume_button.SetActive(false);
        quit_button.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
