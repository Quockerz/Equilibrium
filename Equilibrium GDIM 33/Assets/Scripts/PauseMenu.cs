using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject resume_button;
    [SerializeField] private GameObject quit_button;
    [SerializeField] private GameObject background;

    private AudioSource background_music;
    // Start is called before the first frame update
    void Start()
    {
        resume_button.SetActive(false);
        quit_button.SetActive(false);
        background_music = background.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0; //pause game
            resume_button.SetActive(true);
            quit_button.SetActive(true);

            background_music.Pause();
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        resume_button.SetActive(false);
        quit_button.SetActive(false);

        background_music.Play();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
