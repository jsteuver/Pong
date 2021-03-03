using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 15;
    private float xVector;
    private float yVector;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        xVector = Random.Range(-15.0f, 15.0f);
        yVector = Mathf.Sqrt(speed * speed - xVector * xVector) * (Random.Range(0, 2) * 2 - 1);

        rb.velocity = new Vector2(xVector, yVector);
    }

    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(xVector, yVector);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag.Equals("Wall"))
        {
            yVector = yVector * -1.0f;
        }
        else if (collision.collider.gameObject.tag.Equals("Left"))
        {
            xVector = xVector * -1.0f;
        }
        else if (collision.collider.gameObject.tag.Equals("Right"))
        {
            xVector = xVector * -1.0f;
        }
    }
}
