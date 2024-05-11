using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSc : MonoBehaviour
{
    public Image healthBar;
    public Sprite[] healthBarSprites;
    public int health = 100;
    public GameObject gameOverScreen;
    // Start is called before the first frame update
    public float speed;

    void Start()
    {
        speed = 1.7f;

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); 
        float verticalInput = Input.GetAxis("Vertical");   

        
        Vector2 movement = new Vector2(horizontalInput, verticalInput);

        transform.Translate(movement * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Coins")
        {
            IncreaseHealth(GameManager.coindiff);
            collision.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "Enemy") 
        {
            DecreaseHealth(GameManager.difficultE); 
        }
        if (collision.gameObject.tag == "CheckPoint") 
        {
            
            SceneManager.LoadScene(3);
        }

    }

    public void DecreaseHealth(int damage)
    {
        health -= damage;
        UpdateHealthBar();
    }
   
    public void IncreaseHealth(int bonus)
    {
        health += bonus;
        UpdateHealthBar();
    }
    void UpdateHealthBar()
    {
        
        if (health > 80)
            healthBar.sprite = healthBarSprites[0];
        else if (health > 60)
            healthBar.sprite = healthBarSprites[1];
        else if (health > 40)
            healthBar.sprite = healthBarSprites[2];
        else if (health > 20)
            healthBar.sprite = healthBarSprites[3];
        else if (health<1)
        {
            health = 100;
            SceneManager.LoadScene(2);
        }
            
    }
 
}
