using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMenuMusic : MonoBehaviour
{

    // Play nature music when the menu scene starts
    void Start()
    {
        GameObject.FindWithTag("music").GetComponent<MenuMusic>().PlayMusic();
    }
}
