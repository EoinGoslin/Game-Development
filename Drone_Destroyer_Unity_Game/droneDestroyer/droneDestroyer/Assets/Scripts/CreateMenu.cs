using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CreateMenu : MonoBehaviour
{
    public Text endGameText;
    public Button playNormalButton;
    public Button returnToMenuButton;
    public Button playHardAgain;
    public Color newColour;
    private MonitorGame monitor_game;

    private void Start()
    {
        monitor_game = GameObject.FindWithTag("MonitorGame").GetComponent<MonitorGame>();
    }

    public void SetupMenu(bool ifDied) 
    {
        endGameText.color = newColour;

        // Check if lost or won

        if (ifDied) 
        {
            string txt = "YOU DIED! @ Enemies Killed " + monitor_game.numEnemiesKilled + " @ Heals Left @" + monitor_game.healsLeft;
            txt = txt.Replace("@", System.Environment.NewLine);
            endGameText.text = txt;
        } else 
        {

            string txt = "YOU WON! @ WELL DONE! @ Enemies Killed " + monitor_game.numEnemiesKilled + " @ Heals Left @" + monitor_game.healsLeft;
            txt = txt.Replace("@", System.Environment.NewLine);
            endGameText.text = txt;
        }
        // Make buttons visible again as at the start the alpha is 0 also disabled so that user can not see or press them
        TurnOnButn(playNormalButton);
        TurnOnButn(playHardAgain);
        TurnOnButn(returnToMenuButton);

    }

    public void TurnOnButn(Button btn)
    {
        btn.interactable = true;
        var colors = btn.colors;
        colors.normalColor = Color.white;
        colors.highlightedColor = Color.grey;
        colors.pressedColor = Color.white;
        btn.colors = colors;
        btn.GetComponent<Image>().color = Color.red;
        btn.GetComponentInChildren<Text>().color = Color.white;
    }

}
