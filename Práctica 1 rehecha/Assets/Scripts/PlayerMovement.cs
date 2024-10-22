using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float Speed = 5f;
    [SerializeField] private float MaxLeft = -7.25f, MaxRight = 7.25f;
    [SerializeField] private GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.A)) && (transform.position.x > MaxLeft))
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        if ((Input.GetKey(KeyCode.D)) && (transform.position.x < MaxRight))
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(Bullet, transform.position, Quaternion.identity);   
    }
}
