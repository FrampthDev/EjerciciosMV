using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Text test;
    public static UIManager Instance {get; private set;}
    void Awake(){
        if (Instance!=null && Instance !=this){
            Destroy(this);
        }
        else{
            Instance = this;
        }
 

    }
    void Start()
    {
        test.text = "test";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
