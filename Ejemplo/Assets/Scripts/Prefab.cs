using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Prefab : MonoBehaviour
{
    public GameObject prefab;
    public static extern Object Instantiate(Object original);

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Object.Instantiate(prefab);
    }
}
