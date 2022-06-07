using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractLever : MonoBehaviour
{
    //Levers are 1-way switches that cannot be turned off

    bool withinArea = false;
    bool activated = false;
    [SerializeField] GameObject affectedElement;
    private AudioSource activateSound;
    private bool soundplayed = false;

    SpriteRenderer leverR;

    void Awake()
    {
        leverR = GetComponent<SpriteRenderer>();
        activateSound = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && withinArea && !activated)
        {
            //Places the interactive element
            affectedElement.gameObject.SetActive(true);
            //Flips the state of the lever
            activated = !activated;
            //Additional properties applied utilizing new tag recognized by other scripts if necessary
            affectedElement.gameObject.tag = "Affected";
            Debug.Log("Press");
        }

        //Changes the color of the lever depending on its flip state
        if (activated)
        {
            if (!soundplayed)
            {
                activateSound.Play();
                soundplayed = true;
            }
            leverR.color = Color.green;
        }
        else
        {
            leverR.color = Color.red;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            withinArea = true;
        }
    }
}
