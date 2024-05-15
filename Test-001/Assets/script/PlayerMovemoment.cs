using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovemoment : MonoBehaviour
{
    //[SerializeField] int speed;
    [SerializeField] bool isgrounded;
    [SerializeField] int jumpPower;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] int horizonSpeed;
   
    
    Rigidbody2D rb;
    Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        Movement();
      /*  float Horizon = Input.GetAxis("Horizontal") * horizonSpeed * Time.deltaTime;
        pos = new Vector2(Horizon, pos.y);
        transform.position = pos;*/

    }
    void Movement()
    {
        isgrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(0.7f, 0.3f), CapsuleDirection2D.Horizontal, 0, groundLayer);
        if (Input.GetButtonDown("Jump") && isgrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
        if (Input.GetButtonDown("Horizontal"))
        {
            rb.velocity = new Vector2(horizonSpeed, rb.velocity.y);
        }

       

    }

}
