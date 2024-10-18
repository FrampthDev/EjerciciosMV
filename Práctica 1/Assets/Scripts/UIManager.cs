using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance {get; private set;}
    void awake(){
        if (Instance!=null && Instance !=this){
            Destroy(this);
        }
        else{
            Instance = this;
        }
 

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
