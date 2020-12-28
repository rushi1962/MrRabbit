using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MenuPanel,CreditsPanel,LevelSelectPanel;
    public void GotoLevels()
    {
        CreditsPanel.SetActive(false);
        LevelSelectPanel.SetActive(true);
        MenuPanel.SetActive(false);
    }
    public void GotoCredits()
    {
        CreditsPanel.SetActive(true);
        LevelSelectPanel.SetActive(false);
        MenuPanel.SetActive(false);
    }
    public void Back()
    {
        MenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
        LevelSelectPanel.SetActive(false);
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
