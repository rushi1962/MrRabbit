using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    int _level;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void LoadLevel()
    {
        SceneManager.LoadScene(_level);
    }
}
