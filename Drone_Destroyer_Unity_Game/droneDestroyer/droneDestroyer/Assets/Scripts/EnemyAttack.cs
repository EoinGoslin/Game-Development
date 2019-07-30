using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject enem_Bullet;
    
    public float timeBetweenAttacks = 0.5f;
    public float range = 50f;
    GameObject player;
    public GameObject sparks;
    // will chek player distance
    bool playerInRange = false;
    public Transform bulletPoint;
    public float constant;
    private Vector3 predPos;
    private PlayerHealth player_health;

    float timer;

    private GameObject spark_remover;
   

    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
        player_health = player.GetComponent<PlayerHealth>();
    }

   

    // Update is called once per frame
    void Update()
    {



        // if close enough to player to fire
        if (Vector3.Distance(player.transform.position, transform.position) <= range) {

            playerInRange = true;
        }

       

        timer += Time.deltaTime;
        if (timer >= timeBetweenAttacks && playerInRange && !player_health.isDead) 
        {
            timer = 0f;
            fireWeapon();
        }
        playerInRange = false;
    }


    void fireWeapon() 
    {

        GameObject bullet = Instantiate(enem_Bullet, transform.position, transform.rotation);

    }
    // If the enemy hits the ground, sparks start to fly
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "terrain") 
        {
            spark_remover = Instantiate(sparks, this.transform.position, this.transform.rotation); 
        
        }
    }




    // Attempt at predicting player position
    //predPos = predictedPosition(player.transform.position, transform.position, player.GetComponent<Rigidbody>().velocity, 700f);

    //private Vector3 predictedPosition(Vector3 targetPosition, Vector3 shooterPosition, Vector3 targetVelocity, float projectileSpeed)
    //{
    //    Vector3 displacement = targetPosition - shooterPosition;
    //    float targetMoveAngle = Vector3.Angle(-displacement, targetVelocity) * Mathf.Deg2Rad;
    //    //if the target is stopping or if it is impossible for the projectile to catch up with the target (Sine Formula)
    //    if (targetVelocity.magnitude == 0 || targetVelocity.magnitude > projectileSpeed && Mathf.Sin(targetMoveAngle) / projectileSpeed > Mathf.Cos(targetMoveAngle) / targetVelocity.magnitude)
    //    {
    //        Debug.Log("Position prediction is not feasible.");
    //        return targetPosition;
    //    }
    //    //also Sine Formula
    //    float shootAngle = Mathf.Asin(Mathf.Sin(targetMoveAngle) * targetVelocity.magnitude / projectileSpeed);
    //    print(targetPosition);
    //    return targetPosition + targetVelocity * displacement.magnitude / Mathf.Sin(Mathf.PI - targetMoveAngle - shootAngle) * Mathf.Sin(shootAngle) / targetVelocity.magnitude;
    //}

}
