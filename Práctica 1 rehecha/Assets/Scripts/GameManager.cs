using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    int Bubbles;
    bool EndGame = false;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        Bubbles = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Bubbles == 0) && (EndGame == false))
        {
            UIManager.Instance.Inform("¡Has ganado!");
            EndGame = true; 
        }
    }

    public void OnPlayerDamaged()
    {
        UIManager.Instance.Inform("¡Has perdido!");
    }

    public void OnBubbleCreated()
    {
        Bubbles++;
    }

    public void OnBubbleDamaged()
    {
        Bubbles--;
    }
}
