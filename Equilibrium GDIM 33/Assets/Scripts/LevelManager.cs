using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    [SerializeField] private GameObject top_winPad;
    [SerializeField] private GameObject bottom_winPad;
    [SerializeField] private string nextLevel_name;

    [SerializeField] private GameObject nextlevelButton;
    [SerializeField] private GameObject win_text;

    private SpriteRenderer top_sprite;
    private SpriteRenderer bottom_sprite;

    private void Start()
    {
        nextlevelButton.SetActive(false); // set win buttons to not active when game starts
        win_text.SetActive(false);
    }
    public static void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Update()
    {
        top_sprite = top_winPad.GetComponent<SpriteRenderer>();
        bottom_sprite = bottom_winPad.GetComponent<SpriteRenderer>();

        if((top_sprite.color == Color.green) && (bottom_sprite.color == Color.green)) //if win condition is met
        {
            Time.timeScale = 0; //pause game
            win_text.SetActive(true); //make level complete text appear
            nextlevelButton.SetActive(true); //make next level button appear
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(nextLevel_name);
    }
}
