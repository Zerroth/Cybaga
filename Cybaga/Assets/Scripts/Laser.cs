using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour 
{
	//If the laser collides with building, wall or enemy, it will get destroyed
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Building" || col.gameObject.tag == "Wall" || col.gameObject.tag == "Virus")
		{
			Destroy(gameObject);
		}

	}
}
