using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blowup : MonoBehaviour
{
    [SerializeField] private float InitialForceMagnitude = 5f;
    [SerializeField] private Vector2 InitialForceDirection = new (0.5f, 0.5f);
    Rigidbody2D RB2D;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.OnBubbleCreated();
        RB2D = GetComponent<Rigidbody2D>();
        RB2D.AddForce(InitialForceMagnitude * Time.deltaTime * InitialForceDirection.normalized, ForceMode2D.Impulse);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Burst()
    {
        Destroy(gameObject);
        GameManager.Instance.OnBubbleDamaged();
    }
}
