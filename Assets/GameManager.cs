using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int difficultE=10; // Variable for difficulty level
    public static int coindiff=15; 

    void Awake()
    {
        DontDestroyOnLoad(gameObject); 
    }
    
}
