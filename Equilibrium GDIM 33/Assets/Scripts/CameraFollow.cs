using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject TargetPlayer;

    Vector3 Offset;

    void Start()
    {
        Offset = new Vector3(0, 0, -5);
        gameObject.transform.position = TargetPlayer.transform.position + Offset;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = TargetPlayer.transform.position + Offset;
    }
}
