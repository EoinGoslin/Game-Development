using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{

    public GameObject explosion;
    private MonitorGame monitor_game;
    public GameObject begin_gameObj;
    private BeginGame beginGame;
    private CreateMenu createMenu;

    private void Start()
    {
        monitor_game = GameObject.FindWithTag("MonitorGame").GetComponent<MonitorGame>();
        GameObject gameovercontroller = GameObject.FindWithTag("GameOverController");
        beginGame = begin_gameObj.GetComponent<BeginGame>();
        createMenu = gameovercontroller.GetComponent<CreateMenu>();
    }

    void OnTriggerEnter(Collider other)
    {


        // If the entering collider is the player...
        if (other.gameObject.tag == "bullet")
        {
            // Increase Number of Enemies killed
            monitor_game.numEnemiesKilled += 1;
            // remove the bullet
            Destroy(other);
            // destroy the drone
           
            GameObject[] objects = GameObject.FindGameObjectsWithTag("enemy_drone");
            foreach (GameObject go in objects)
            {
                if (go == gameObject) 
                {
                    // remove this drone
                    Destroy(go);
                }

            }
            // create an explosion where the drone was blown up
           Instantiate(explosion, other.transform.position, other.transform.rotation);
           
            // Check if game over
            if (monitor_game.numEnemiesKilled == (beginGame.amountOfEnemies + 1)) 
            {
                // Game Over
                createMenu.SetupMenu(false);
            }
        }
    }
}
