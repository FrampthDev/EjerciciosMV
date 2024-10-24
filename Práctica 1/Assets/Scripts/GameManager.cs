using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static GameManager Instance {get; private set;}

    
    bool endGame=false;
    int nBubbles;

    void Awake(){
        if (Instance!=null && Instance !=this){
            Destroy(this);
        }
        else{
            Instance = this;
        }
        nBubbles=0;

    }


    //Comienza el GameManager
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void OnPlayerDamaged(){
        endGame = true;
    }

    public void OnBubbleCreated(){
        nBubbles++;
    }

    public void OnBubbleDamaged(){
        nBubbles--;
    }
}
