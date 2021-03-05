using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float velocity = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb2 = GetComponent<Rigidbody2D>();

        rb2.velocity = new Vector2(Input.GetAxis("Horizontal") * velocity, rb2.velocity.y);
        rb2.velocity = new Vector2(rb2.velocity.x, Input.GetAxis("Vertical") * velocity);

        // Teleport the game object
        if (transform.position.x > 9)
        {
            transform.position = new Vector3(-9, transform.position.y, 0);
        }
        else if (transform.position.x < -9)
        {
            transform.position = new Vector3(9, transform.position.y, 0);
        }
        else if (transform.position.y > 5)
        {
            transform.position = new Vector3(transform.position.x, -5, 0);
        }
        else if (transform.position.y < -5)
        {
            transform.position = new Vector3(transform.position.x, 5, 0);
        }


        /*if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.A) ...)
        {
            rb2.velocity = new Vector2(-1f, rb2.velocity.y);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2.velocity = new Vector2(1f, rb2.velocity.y);
        }*/

        /*if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb2.velocity = new Vector2(rb2.velocity.x, 1f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb2.velocity = new Vector2(rb2.velocity.x, -1f);
        }*/
    }
}
