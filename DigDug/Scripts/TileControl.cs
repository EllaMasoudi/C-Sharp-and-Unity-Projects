using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileControl : MonoBehaviour
{
    public Vector2 tilePos;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tilePos = GetComponent<Transform>().position;

        
        if ((tilePos.x == 6) && (tilePos.y == 2))
        {
            Destroy(gameObject);
        }
        if ((tilePos.x == 5) && (tilePos.y == 2))
        {
            Destroy(gameObject);
        }
        if ((tilePos.x == -1) && (tilePos.y == -4 ))
        {
            Destroy(gameObject);
        }
        if ((tilePos.x == -3) && (tilePos.y == -1))
        {
            Destroy(gameObject); 
        }
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            if(gameObject.name == "RockSupport")
            {
                GameFlow.supportGone = "y";
              
            }
            Destroy(gameObject);
        }
    }
}
