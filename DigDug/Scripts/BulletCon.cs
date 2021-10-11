using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCon : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Enemy")
        {
           Destroy(gameObject);
           other.gameObject.GetComponent<myGame.Enemy>().TakeDamage(damage);

        }
    }
}
