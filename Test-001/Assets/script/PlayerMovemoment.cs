using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovemoment : MonoBehaviour
{
    [SerializeField] int speed;
    [SerializeField] bool groundi= false;
    [SerializeField] Rigidbody2D rb;

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
        pos = transform.position;
        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, -5f, 2.5f);
        transform.position = pos;
        //float Horizone = Input.GetAxis("Horizontal")* 
    }

}
