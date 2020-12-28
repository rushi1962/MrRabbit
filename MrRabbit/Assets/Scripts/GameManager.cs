using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager gm;
    public int Carrots;
    public float GameTime=60f;
    public bool PlayerAlive,GamePaused;
    public Text CarrotCounter,Timer; 
    public GameObject ControlPanel, PausePanel, GameOverPanel;
    public KillPlayer killer;
    void Awake()
    {
        if (gm == null)
            gm = this.GetComponent<GameManager>();
    }
    void Start()
    {
        killer = GameObject.FindGameObjectWithTag("PlayerKiller").GetComponent<KillPlayer>();
        PlayerAlive = true;
        GamePaused = false;
        Carrots = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(GamePaused)
        {
            Time.timeScale = 0f;
            ControlPanel.SetActive(false);
            PausePanel.SetActive(true);
        }
        else
        {
            if (!PlayerAlive)
            {
                Time.timeScale = 0f;
                ControlPanel.SetActive(false);
                GameOverPanel.SetActive(true);
            }
            else
            {
                Time.timeScale = 1f;
                ControlPanel.SetActive(true);
                PausePanel.SetActive(false);
            }

        }
       
        if(GameTime<=0f)
        {
            killer.KillThePlayer();
            Timer.text = "0.0";
        }
        if(GameTime>0f)
        {
            GameTime -= Time.deltaTime;

            Timer.text = GameTime.ToString("0.0");
        }
       
        CarrotCounter.text = Carrots.ToString();
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
