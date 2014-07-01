using UnityEngine;
using System.Collections;

public class enemy1 : MonoBehaviour {
	
	public GameObject blueBox;
	System.Random rand = new System.Random();
	
	void Start () {
		Spawn();
	}
	
	
	void Update () {
		if (rand.NextDouble()<0.01){
			Spawn ();
		}
	}
	
	void Spawn (){
		Instantiate(blueBox);
	}
}
