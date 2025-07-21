using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rbody;
    public float JumpForce = 10f;

    public float CapsuleHeight = .1f;
    public float CapsuleRadius = .1f;

    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;
    private float fallForce = -1;
    private Vector2 gravityForce;
    
    // Start is called before the first frame update
    void Start()
    {
        gravityForce = new Vector2(0, Physics2D.gravity.y);
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _groundCheck = Physics2D.OverlapCapsule(point: feetCollider.position,
                size: new Vector2(CapsuleHeight, CapsuleRadius), CapsuleDirection2D.Horizontal,
                angle: 0, groundMask);
        if (Input.GetKeyDown(KeyCode.Space) && _groundCheck) { 
        
            rbody.velocity = new Vector2(rbody.velocity.x, JumpForce);
           
        }
        if(rbody.velocity.y < 0)
        {
            rbody.velocity += gravityForce * (fallForce * Time.deltaTime);
        }
    }
}
