using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class ScriptSpike : MonoBehaviour
{
    public float speed = 5f;
    public float alturaMax = 4.5f;
    
    public GameObject bubble;
    public static extern Object Instantiate(Object original);

    //public GameObject spikeGameObject;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (transform.position.y >= alturaMax)
            Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Object.Instantiate(bubble, transform.position, transform.rotation);
    }
}
