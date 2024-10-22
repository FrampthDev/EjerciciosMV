using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleHarmfull : MonoBehaviour
{
    //public GameObject bubble;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision){
 

        if (collision.gameObject==null){
            Debug.Log("null");
        }else
        {
            PlayerHealth health = collision.gameObject.GetComponent<PlayerHealth>();
            if (health != null){
                health.Harm();
                
            }
        }
        Debug.Log("Collision"); 
        // Comprueba si la colisión ha sido con PlayerHealth, si es correcto, llama a la función Harm del objecto PlayerHealth. 
    }
}
