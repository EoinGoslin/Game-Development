using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BeginGame : MonoBehaviour
{
    public GameObject Enemy;
    public int amountOfEnemies;
    private DifficultyMode difficultyMode;
    public GameObject player;
    public GameObject monitorGameObj;
    private PlayerHealth player_health;
    private MonitorGame monitor_game;
    private CheckIfHit checkIfHit;


    private void Start()
    {
        // depending on level of difficulty, different number of players
        GameObject diffObj = GameObject.FindWithTag("DiffMode");
        player_health = player.GetComponent<PlayerHealth>();
        monitor_game = monitorGameObj.GetComponent<MonitorGame>();
        checkIfHit = player.GetComponent<CheckIfHit>();
        difficultyMode = diffObj.GetComponent<DifficultyMode>();
       

        if (difficultyMode.levelOfDiff == 1) 
        {
            // normal mode
            amountOfEnemies = 4;
            player_health.numberOfHeals = 3;
            checkIfHit.damageFromEnemy = 10;
            monitor_game.healsLeft = 3;
            monitor_game.UpdateHealDisplay(3);

        } else 
        {
            // hard mode
            amountOfEnemies = 9;
            player_health.numberOfHeals = 1;
            checkIfHit.damageFromEnemy = 20;
            monitor_game.healsLeft = 1;
            monitor_game.UpdateHealDisplay(1);

        }


        SpawnEnemies();

    }

    // Places enemies in random locations around the map
    void SpawnEnemies()
    {
        for (int i =0; i < amountOfEnemies; i++)
        {
            var position = new Vector3(Random.Range(0, -4000), Random.Range(0, 500), Random.Range(0, -3000));
            Instantiate(Enemy, position, Quaternion.identity);
        }
    }

}
