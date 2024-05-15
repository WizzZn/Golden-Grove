using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    }

    // Update is called once per frame
    void Update()
    {
        
        Movement();
      

    }
    void Movement()
    {
        isgrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(0.7f, 0.3f), CapsuleDirection2D.Horizontal, 0, groundLayer);
        if (Input.GetButtonDown("Jump") && isgrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
           
        }
       /* else
        {
            isgrounded = false;
        }*/

        pos = transform.position;
        float Horizon = Input.GetAxis("Horizontal") * horizonSpeed *Time.deltaTime;
        pos.x += Horizon;
        transform.position = pos;

    }

}
