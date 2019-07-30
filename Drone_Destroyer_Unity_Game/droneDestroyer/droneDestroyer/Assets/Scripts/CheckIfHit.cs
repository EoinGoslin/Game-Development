using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfHit : MonoBehaviour
{

    // on hard is be more
    public int damageFromEnemy;
    public AudioClip noiseWhenHit;

   
   
   
    public GameObject explosion;

    private PlayerHealth playerHealth;

    private void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
    }


    void OnTriggerEnter(Collider other)
    {
        // If entering collider is the player...
        if (other.gameObject.tag == "EnemyBullet")
        {


            playerHealth.TakeDamage(damageFromEnemy);
            Instantiate(explosion, this.transform.position, this.transform.rotation);
        }
        // If entering collider is the healer...
        if (other.gameObject.tag == "healing")
        {



            // heal the payer
            // check if number of heals used up
            if (playerHealth.numberOfHeals > 0) 
            {
                if (playerHealth.currentHealth != playerHealth.startingHealth) 
                {

                    playerHealth.HealPlayer();
                }

            }
          

        }

    }

}
