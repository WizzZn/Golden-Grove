using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] LayerMask water;
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
        else if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Water")
        {
            gameObject.SetActive(false);
        }
    }
   
}
