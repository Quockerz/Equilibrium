using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CheckWin : MonoBehaviour
{
    private SpriteRenderer winpad_spriteRenderer;

    void OnTriggerEnter2D(Collider2D other)
    {
        winpad_spriteRenderer = GetComponent<SpriteRenderer>();
        winpad_spriteRenderer.color = Color.green;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        winpad_spriteRenderer = GetComponent<SpriteRenderer>();
        winpad_spriteRenderer.color = Color.black;
    }
}
