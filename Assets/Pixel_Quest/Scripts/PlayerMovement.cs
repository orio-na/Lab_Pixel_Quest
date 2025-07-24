using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 7;
    private SpriteRenderer sr1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr1 = transform.GetChild(0).GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal");
        if (xSpeed <= -.1)
        {
            sr1.flipX = false;
        }
        else if (xSpeed >= .1)
        {
            sr1.flipX = true;
        }
            rb.velocity = new Vector2(xSpeed * speed, rb.velocity.y);
    }
}
