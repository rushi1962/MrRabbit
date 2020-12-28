using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerPrefsManager
{
	// Start is called before the first frame update
	public static int GetHighLevel()
	{
		if (PlayerPrefs.HasKey("HighLevel"))
		{
			return PlayerPrefs.GetInt("HighLevel");
		}
		else
		{
			return 1;
		}

	}
	public static void SetHighLevel(int highLevel)
	{
		if(highLevel>8)
        {
			return;
        }			
		PlayerPrefs.SetInt("HighLevel", highLevel);
	}
}
