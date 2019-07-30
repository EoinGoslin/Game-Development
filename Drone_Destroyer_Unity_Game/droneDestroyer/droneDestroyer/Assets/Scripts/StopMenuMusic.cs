using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMenuMusic : MonoBehaviour
{
    // Stop the music when not in main menu or help menu i.e. when playing game
    void Start()
    {
        GameObject.FindGameObjectWithTag("music").GetComponent<MenuMusic>().StopMusic();
    }
}
