using UnityEngine;
using System.Collections;

public class MenuIntro : MonoBehaviour {
	
	int highscore = Highscore.highscore;
	
	void OnGUI()
	{
		if (GUI.Button (new Rect(10,10,100,50),"Start"))
		{
			Application.LoadLevel(1);
		}
		GUI.Label (new Rect(10,70,100,50),"Highscore: "+highscore);

		if (GUI.Button (new Rect(10,130,100,50),"Exit"))
		{
			Application.Quit();
		}
	}
}
