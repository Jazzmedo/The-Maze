using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraa : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0.9f, -0.34f, -1); 
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x >= 0.9 && player.transform.position.x <= 43.92)
        {
            transform.position = new Vector3(player.transform.position.x, -0.34f, -1);
        }
        
    }
}
