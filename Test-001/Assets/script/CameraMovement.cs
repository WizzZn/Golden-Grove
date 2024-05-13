using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject cameraPoss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (new Vector3(cameraPoss.transform.position.x, cameraPoss.transform.position.y, -10));
    }
    void Awake()
    {

    }
}
