using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blowup : MonoBehaviour
{
    //[SerializeField] private UnityEngine.Vector2 InitialForceDirection = Vector2(2,2).Normalize;
    [SerializeField] private float InitialForceMagnitude = 5f;
    // Start is called before the first frame update
    void Start()
    {
       // Transform.Translate(InitialForceDirection * InitialForceMagnitude * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
