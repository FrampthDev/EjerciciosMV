using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
       
        if (Input.GetKey(KeyCode.A) && transform.position.x > -7.25)
            transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D) && transform.position.x < 7.25)
            transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
            Object.Instantiate(Spike);
                 
        
    }
}
