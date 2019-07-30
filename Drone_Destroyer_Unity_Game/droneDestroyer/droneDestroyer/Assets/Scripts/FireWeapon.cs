using UnityEngine;


public class FireWeapon : MonoBehaviour
{
    public GameObject Bullet;
    private GameObject drone;
    private PlayerHealth player_health;
    private void Start()
    {
        drone = GameObject.FindWithTag("Player");
        player_health = GetComponent<PlayerHealth>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // So if player hits space bar but is dead, they can no longer fire
            if (!player_health.isDead)
            {
                GameObject bullet = Instantiate(Bullet, drone.transform.position, drone.transform.rotation);
                bullet.GetComponent<Bullet>().travelDirection = drone.transform.forward;
            }
        }

    }
 }

