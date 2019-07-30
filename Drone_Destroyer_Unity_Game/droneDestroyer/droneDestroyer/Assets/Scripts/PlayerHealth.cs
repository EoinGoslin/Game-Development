using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Following this Unity tutorial I was able to make the whole screen go red when a player is shot
// https://unity3d.com/learn/tutorials/s/survival-shooter-tutorial

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public int numberOfHeals;
    public Image damageImage;
    public AudioClip deathClip;
    private DroneMovement droneMovement;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    private CreateMenu createMenu;
    private MonitorGame monitor_game;
    public bool isDead;
    bool damaged;


    private void Awake()
    {
        monitor_game = GameObject.FindWithTag("MonitorGame").GetComponent<MonitorGame>();
        droneMovement = GetComponent<DroneMovement>();
        currentHealth = startingHealth;
        GameObject gameovercontroller = GameObject.FindWithTag("GameOverController");
        createMenu = gameovercontroller.GetComponent<CreateMenu>();

    }
    
    // The canvas alpha is originally set to 0, this is then changed and colour set to red when player is damaged
    void Update()
    {
        if (damaged) {
            damageImage.color = flashColour;
        } else {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);

        }
        damaged = false;   
    }

    // deduct health from player and move slider down accordingly
    public void TakeDamage (int amount) 
    {
        damaged = true;
        currentHealth -= amount;
        healthSlider.value = currentHealth;

        if (currentHealth <= 0 && !isDead) 
        {
            Death();   
        }
    }

    void Death()
    {
        isDead = true;
        droneMovement.enabled = false;      

        //call create menu here, true means player died - message that appears to the user is different then
        createMenu.SetupMenu(isDead);
    }


   public void HealPlayer() 
    {
        numberOfHeals -= 1;
        monitor_game.healsLeft = numberOfHeals;
        monitor_game.UpdateHealDisplay(numberOfHeals);
        currentHealth = startingHealth;
        healthSlider.value = currentHealth;
    }


}
