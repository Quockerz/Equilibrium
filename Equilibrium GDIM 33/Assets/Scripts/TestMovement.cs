using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    
    [SerializeField] private float velocity = 7.0f;
    [SerializeField] private float jumpForce = 30.0f;

    private bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            rb2D.AddForce(transform.right * velocity, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb2D.AddForce(transform.right * -velocity, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.W) && grounded)
        {
            rb2D.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8 && !grounded)
        {
            grounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8 && grounded)
        {
            grounded = false;
        }
    }

}
