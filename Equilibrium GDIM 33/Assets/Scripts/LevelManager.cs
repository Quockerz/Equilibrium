using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject top_winPad;
    [SerializeField] private GameObject bottom_winPad;
    [SerializeField] private string level_name;

    private SpriteRenderer top_sprite;
    private SpriteRenderer bottom_sprite;

    public static void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Update()
    {
        top_sprite = top_winPad.GetComponent<SpriteRenderer>();
        bottom_sprite = bottom_winPad.GetComponent<SpriteRenderer>();

        if((top_sprite.color == Color.green) && (bottom_sprite.color == Color.green))
        {
            SceneManager.LoadScene(level_name);
        }
    }
}
