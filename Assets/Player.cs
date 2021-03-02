using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private int speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(0, speed * -1);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(0, speed);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
