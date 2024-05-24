using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Animator enemy;
     public  GameObject player;
    [SerializeField] float enemySpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTo();
    }
    void MoveTo()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, enemySpeed);
        //public float dist = Vector3.Distance()
    }
}
