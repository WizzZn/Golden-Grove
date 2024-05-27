using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trap : MonoBehaviour
{
    public int key = 0;
    public int coin = 0;

    [SerializeField] LayerMask water;
    [SerializeField] Animator player;
    [SerializeField] Animator chest;
    [SerializeField] Animator cup;
    [SerializeField] Animator finish;
    [SerializeField] Animator respawn;
    [SerializeField] Animator enemy;
    [SerializeField] TextMeshProUGUI coinTM;
    [SerializeField] TextMeshProUGUI keyTM;

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
        if (collision.gameObject.tag == "Water")
        {
            gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            player.SetBool("Hit", true);
            Debug.Log("Hit");
        }

        if (collision.gameObject.tag == "Key")
        {
            Debug.Log("collected");
            key += 1;
            keyTM.text = key.ToString();
            Destroy(collision.gameObject);
        }
        if (key == 1)
        {
            if (collision.gameObject.tag == "Chest")
            {
                chest.SetBool("Open", true);
                Debug.Log("chest open");
                coin += 10;
            }
        }
        if (collision.gameObject.tag == "Cup")
        {
            cup.SetBool("Finish", true);
            Debug.Log("Finish");
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            finish.SetBool("Flaping", true);
            enemy.SetBool("Hit", true);
        }
        if (collision.gameObject.tag == "Respawn")
        {
            respawn.SetBool("Flaping", true);

        }
        if (collision.gameObject.tag == "Coin")
        {
            coin += 1;
            coinTM.text = coin.ToString();
            Destroy(collision.gameObject);

        }
    }
}
