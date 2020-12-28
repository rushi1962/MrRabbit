using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player,blood;
    public LevelComplete check;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        check = GameObject.FindGameObjectWithTag("LevelFinisher").GetComponent<LevelComplete>();
    }

    // Update is called once per frame
    public void KillThePlayer()
    {
        if(player!=null&&!check.LevelCompleteCheck)
        {
            Instantiate(blood, player.transform.position, player.transform.rotation);
            Invoke("PlayerDead", 1f);
            print("Dead");
            Destroy(player.gameObject);
        }
        
    }
    void PlayerDead()
    {
        GameManager.gm.PlayerAlive = false;
    }
}
