using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleHarmfull : MonoBehaviour
{
    public GameObject bubble;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        // detecta si hay una colisión
        if (collision.gameObject.GetComponent<PlayerHealth>() != null){
            collision.gameObject.GetComponent<PlayerHealth>().Harm();
        }
        // Comprueba si la colisión ha sido con PlayerHealth, si es correcto, llama a la función Harm del objecto PlayerHealth. 
    }
}
