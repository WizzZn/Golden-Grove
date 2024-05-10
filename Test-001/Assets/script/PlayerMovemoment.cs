using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovemoment : MonoBehaviour
{
    Vector2 pos;
    Vector2 pos2;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        pos.y += Input.GetAxis("Jump") * speed * Time.deltaTime;
        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, -5f, 2.5f);
        transform.position = pos;


    }

}
