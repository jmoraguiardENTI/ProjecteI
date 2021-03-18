using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float velocity = 0f;

    private Rigidbody2D rb2 = null;

    private Animator animator = null;

    private SpriteRenderer renderer = null;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();

        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2.velocity = new Vector2(Input.GetAxis("Horizontal") * velocity, rb2.velocity.y);
        //rb2.velocity = new Vector2(rb2.velocity.x, Input.GetAxis("Vertical") * velocity);

        animator.SetFloat("Velocity", Mathf.Abs(rb2.velocity.x));

        if (rb2.velocity.x < 0)
        {
            renderer.flipX = true;
        }

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
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("I have entered a trigger");
    }
}
