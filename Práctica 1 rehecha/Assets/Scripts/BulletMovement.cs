using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletMovement : MonoBehaviour
{
    public float Speed = 5f, MaxHeight = 4.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Speed * Time.deltaTime);

        if (transform.position.y >= MaxHeight)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Blowup>())
        {
            collision.gameObject.GetComponent<Blowup>().Burst();
            Destroy(gameObject);
        }
    }
}
