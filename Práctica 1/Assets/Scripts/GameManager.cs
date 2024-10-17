using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static GameManager Instance {get; private set;}

    void awake(){
        if (Instance!=null && Instance !=this){
            Destroy(this);
        }
        else{
            Instance = this;
        }
    }
    bool endGame=false;

    //Comienza el GameManager
    void Start()
    {
        Debug.Log("hola mundo");
    }

    // Update is called once per frame
    void Update()
    {
        if (endGame){
            Debug.Log("Fin de partida");
        }
    }

    public void OnPlayerDamaged(){
        endGame= true;
    }
}
