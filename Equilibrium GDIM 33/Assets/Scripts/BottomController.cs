using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomController : MonoBehaviour
{
    private Rigidbody2D rb2D;

    [SerializeField] private float velocity = 1.0f;
    [SerializeField] private float jumpForce = 15.0f;

    private bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2D.AddForce(transform.right * velocity, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2D.AddForce(transform.right * -velocity, ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.UpArrow) && grounded)
        {
            rb2D.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground" && !grounded)
        {
            grounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground" && grounded)
        {
            grounded = false;
        }
    }

}
