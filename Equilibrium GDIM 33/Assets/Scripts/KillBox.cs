using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        LevelManager.Restart();
    }
}
