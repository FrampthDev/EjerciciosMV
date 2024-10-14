using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleDestroyer : MonoBehaviour
{
    public GameObject bubble;
    public static extern Object Instantiate(Object original);
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
        Destroy(collision.gameObject);
        Destroy(gameObject);
        //Object.Instantiate(bubble, transform.position, transform.rotation);
    }
}

