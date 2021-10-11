using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockControl : MonoBehaviour
{

    void Start()
    {
        GetComponent<PolygonCollider2D>().enabled = false;
    }

    void Update()
    {
        GetComponent<PolygonCollider2D>().enabled = true;

        if (GameFlow.supportGone == "y")
        {
            StartCoroutine(dropRock());
            GameFlow.supportGone = "n";
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "BottomBorder")
        {
            
            Destroy(gameObject);
        }
        else if (other.name == "Player")
        {
            Debug.Log("score reduced!!");
            
        }
    }

    IEnumerator dropRock()
    {
        
        yield return new WaitForSeconds (3);
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }

}
