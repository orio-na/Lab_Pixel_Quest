using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class gameController : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 7;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xSpeed * speed, rb.velocity.y);
    }
      /*
       if (Input.GetKeyDown(KeyCode.Space))
        {
           transform.position += new Vector3(0,1,0);
        }
       if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0,-1,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(.008f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-.008f, 0, 0);
        }*/
    
}