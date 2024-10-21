using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blowup : MonoBehaviour
{
    [SerializeField] private float initialForceMagnitude = 5f;
    [SerializeField] private Vector2 initialForceDirection = new (0.5f, 0.5f);
    Rigidbody2D rb2D;   
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.AddForce(initialForceMagnitude * Time.deltaTime * initialForceDirection.normalized, ForceMode2D.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
