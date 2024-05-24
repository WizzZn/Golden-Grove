using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] LayerMask water;
    [SerializeField] Animator player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Trap")
        {
            gameObject.SetActive(false);
        
        }
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Water")
        {
            gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            player.SetBool("Hit", true);
            Debug.Log("Hit");

        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            player.SetBool("Hit", false);
            Debug.Log("Hitachi");
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            player.SetBool("Hit", true);
            Debug.Log("Hit stay");

        }
    }
}
