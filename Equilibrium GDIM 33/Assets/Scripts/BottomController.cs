using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomController: MonoBehaviour
{

    private Rigidbody2D rb2D;
    private BoxCollider2D boxcollider2d;
    [SerializeField] private LayerMask platformLayerMask;

    private void Awake(){
        rb2D = transform.GetComponent<Rigidbody2D>();
        boxcollider2d = transform.GetComponent<BoxCollider2D>();
    }

    private void Update(){
        float moveSpeed = 14f;

        if(isGrounded() && Input.GetKeyDown(KeyCode.UpArrow)){
            float jumpVelocity = 20f;
            rb2D.velocity = Vector2.up * jumpVelocity;
        }
        else if(Input.GetKey(KeyCode.LeftArrow)){
            rb2D.velocity = new Vector2(-moveSpeed, rb2D.velocity.y);
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            rb2D.velocity = new Vector2(+moveSpeed, rb2D.velocity.y);
        }
        else{
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
        }
    }

    private bool isGrounded(){
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxcollider2d.bounds.center, boxcollider2d.bounds.size, 0f, Vector2.down * .1f, platformLayerMask);
        Debug.Log(raycastHit2d.collider);
        return raycastHit2d.collider != null;
    }


    private void HandleMovement(){

        float moveSpeed = 10f;

        if(Input.GetKey(KeyCode.LeftArrow)){
            rb2D.velocity = new Vector2(-moveSpeed, rb2D.velocity.y);
        }
        else{
            if(Input.GetKey(KeyCode.RightArrow)){
                rb2D.velocity = new Vector2(moveSpeed, rb2D.velocity.y);
            }
            else{
                rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            }
        }
    }
}


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class BottomController : MonoBehaviour
// {
//     private Rigidbody2D rb2D;

//     [SerializeField] private float velocity = 1.0f;
//     [SerializeField] private float jumpForce = 15.0f;

//     private bool grounded;

//     // Start is called before the first frame update
//     void Start()
//     {
//         rb2D = gameObject.GetComponent<Rigidbody2D>();
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (Input.GetKey(KeyCode.RightArrow))
//         {
//             rb2D.AddForce(transform.right * velocity, ForceMode2D.Impulse);
//         }
//         if (Input.GetKey(KeyCode.LeftArrow))
//         {
//             rb2D.AddForce(transform.right * -velocity, ForceMode2D.Impulse);
//         }
//         if (Input.GetKey(KeyCode.UpArrow) && grounded)
//         {
//             rb2D.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
//         }

//     }

//     void OnCollisionEnter2D(Collision2D collision)
//     {
//         if (collision.gameObject.tag == "ground" && !grounded)
//         {
//             grounded = true;
//         }
//     }
//     void OnCollisionExit2D(Collision2D collision)
//     {
//         if (collision.gameObject.tag == "ground" && grounded)
//         {
//             grounded = false;
//         }
//     }

// }
