using UnityEngine;
using System.Collections;

public class LevelFinish : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	//If the player flies into this sphere object which is the core, the level ends
	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Player")
		{
			Application.LoadLevel("EndGame");
		}
	}
}
