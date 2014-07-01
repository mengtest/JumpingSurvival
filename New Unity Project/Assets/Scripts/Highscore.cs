using UnityEngine;
using System.Collections;

public class Highscore : ScriptableObject {
	
	static public int highscore = 0;
	
	void Awake()
	{

	}
	public static void CheckScore (){
		if (Scorecounter.score > highscore){
			highscore = Scorecounter.score;
			Debug.Log("New Highscore: "+highscore);
		}
	}
}
