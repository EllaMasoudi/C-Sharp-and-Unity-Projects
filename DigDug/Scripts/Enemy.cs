using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace myGame
{
    public class Enemy : MonoBehaviour
    {
        public int health = 100;
//        public GameObject deathEffact;
        public float speed;
        private Transform target;
        public float stoppingDistance;


        public void TakeDamage(int damage)
        {
            health -= damage;
            if (health <= 0)
            {
                Die();
            }
        }
        void Die()
        {
            GameObject  player = GameObject.FindWithTag("Player");



            if (player)
            {
              
                player.GetComponent<myGame.Player>().score += 1;

                
                player.GetComponent<myGame.Player>().textScore.text = "Score: " + player.GetComponent<myGame.Player>().score.ToString();

            }

           
            Destroy(gameObject);
        }
      
        
        void Update()
        {
            if (GameObject.FindWithTag("Player"))
            {
                target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
                if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
                {

                    transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                }
            }

        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.name == "Rock")
            {

                this.gameObject.SetActive(false);

                Destroy(gameObject);
                transform.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX |
                RigidbodyConstraints2D.FreezePositionX;

            }
        }
    }
}


