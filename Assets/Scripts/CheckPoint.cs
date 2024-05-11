using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject gameOverScreenButtoun;
  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") // Check for collision with player
        {
            gameOverScreenButtoun.SetActive(true);
            gameOverScreen.SetActive(true);
            // Activate the GameOver screen
            Time.timeScale = 0; // Optionally freeze the game
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
