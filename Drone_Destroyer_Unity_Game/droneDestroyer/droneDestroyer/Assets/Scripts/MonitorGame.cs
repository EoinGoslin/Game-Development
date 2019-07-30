using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonitorGame : MonoBehaviour
{
    // Class responsible for updating number of heals displayed on the canvas
    private PlayerHealth player_health;
    public GameObject player;
    GameObject text;
    public int numEnemiesKilled;
    public int healsLeft;


    private void Awake()
    {
        player_health = player.GetComponent<PlayerHealth>();
        text = GameObject.FindWithTag("heal_text");
        
    }
    public void UpdateHealDisplay(int numberOfHeals)
    {
        text.GetComponent<Text>().text = "Heals Left: " + numberOfHeals;
    }
}
