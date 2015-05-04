using UnityEngine;
using System.Collections;

public class EnemyCollisions : MonoBehaviour 
{
	//Enemy's life is set to 1
	public int enemyLife = 1;
	//AudioClip enemyHit;

	// Update is called once per frame
	void Update () 
	{
		//if enemy life is less than 1 then destroy game object
		if(enemyLife < 1)
		{
			Destroy (gameObject);
		}
	}

	//When enemy collides with
	void OnCollisionEnter(Collision col)
	{
		// If if the collided object is a laser,
		if(col.gameObject.tag == "Laser")
		{
			enemyLife -= 1; // Enemy loses a life
			if(enemyLife < 1)
			{
				Destroy (gameObject);
			}
		}
		if(col.gameObject.tag == "Player") //if the enemy collides with a player, restart level
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
