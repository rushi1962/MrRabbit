using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    // Start is called before the first frame update
    public void Pause()
    {
        GameManager.gm.GamePaused = true;
    }
    public void Resume()
    {
        GameManager.gm.GamePaused = false;
    }
    public void Restart()
    {
        GameManager.gm.Restart();
    }
    public void Replay()
    {
        GameManager.gm.Replay();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    
}
