using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This object is attached to the UI buttons 
// Depending on what button, a different method here will be called loading the required scene
public class MenuHandler : MonoBehaviour
{


    private DifficultyMode difficultyMode;


    private void Awake()
    {
        GameObject diffObj = GameObject.FindWithTag("DiffMode");
        difficultyMode = diffObj.GetComponent<DifficultyMode>();


    }

    public void PlayGameNormal()
    {
        // set normal here 
        difficultyMode.levelOfDiff = 1;
        SceneManager.LoadScene(1);
    }

    public void PlayGameHard()
    {
        // set normal here 
        difficultyMode.levelOfDiff = 2;
        SceneManager.LoadScene(1);
    }


    public void GoToMenu()
    {
        SceneManager.LoadScene(2);
    }

        public void QuitGame()
    {
        // if in build mode
        //Application.Quit();

        // if in the editor
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void backToMenu() 
    {
        SceneManager.LoadScene(0);     
    }
}
