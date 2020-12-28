using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public GameObject Panel;
    public bool LevelCompleteCheck;
    public int highLevel;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            Panel.SetActive(true);
            animator.SetBool("levelComplete",true);
            LevelCompleteCheck = true;
            highLevel = PlayerPrefsManager.GetHighLevel();
            if(highLevel<8)
            {
                PlayerPrefsManager.SetHighLevel(highLevel+1);
            }
            Invoke("FinishLevel",2f);
        }
    }
    void FinishLevel()
    {
        GameManager.gm.LoadNextScene();
    }
}
