using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject positive, negative;
    public int HighLevel,thisLevel;
    void Start()
    {
        HighLevel = PlayerPrefsManager.GetHighLevel();
    }

    // Update is called once per frame
    void Update()
    {
        if(HighLevel>=thisLevel)
        {
            positive.SetActive(true);
            negative.SetActive(false);
        }
        else
        {
            positive.SetActive(false);
            negative.SetActive(true);
        }
    }
}
