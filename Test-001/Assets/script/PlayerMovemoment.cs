using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerMovemoment : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 pos;
    public int clikCounter;
    bool doubleJump;
    float horizon;
    

    //[SerializeField] int speed;
    [SerializeField] bool isgrounded;
    [SerializeField] int jumpPower;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] int horizonSpeed;
    [SerializeField] int speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Jump();
        horizon = Input.GetAxis("Horizontal");

    }
    void Jump()
    {
        isgrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(0.7f, 0.3f), CapsuleDirection2D.Horizontal, 0, groundLayer);
        if (isgrounded && !Input.GetButton("Jump"))
        {
            doubleJump = false;
        }
        if (Input.GetButtonDown("Jump"))
        {
           if (isgrounded || doubleJump)
           {
                rb.velocity = new Vector2(rb.velocity.x, jumpPower);

                doubleJump = !doubleJump;
           }
           
        }
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x,rb.velocity.y * 0.5f);
        }

        
        
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizon * speed * Time.deltaTime, rb.velocity.y);
    } 

}
