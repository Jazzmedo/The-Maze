using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int difficultE=10; // Variable for difficulty level
    public static int coindiff=15; // Variable for difficulty name (optional)

    void Awake()
    {
        DontDestroyOnLoad(gameObject); // Persist across scenes
    }
    
}
