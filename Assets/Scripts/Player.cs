using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 0.2f;
    bool blockedUp, blockedDown;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        blockedUp = false;
        blockedDown = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.DownArrow) && !blockedDown)
        {
            rb.MovePosition(new Vector2(transform.position.x, transform.position.y - speed));
            blockedUp = false;
        }
        else if (Input.GetKey(KeyCode.UpArrow) && !blockedUp)
        {
            rb.MovePosition(new Vector2(transform.position.x, transform.position.y + speed));
            blockedDown = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Top Wall"))
        {
            rb.MovePosition(new Vector2(transform.position.x, collision.gameObject.transform.position.y - (collision.gameObject.transform.localScale.y / 2.0f + this.transform.localScale.y / 2.0f)));
            blockedUp = true;
        }
        else if (collision.gameObject.name.Equals("Bottom Wall"))
        {
            rb.MovePosition(new Vector2(transform.position.x, collision.gameObject.transform.position.y + (collision.gameObject.transform.localScale.y / 2.0f + this.transform.localScale.y / 2.0f)));
            blockedDown = true;
        }
    }
}
