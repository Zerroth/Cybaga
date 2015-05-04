using UnityEngine;
using System.Collections;

public class SpaceMovement : MonoBehaviour 
{
	private float shipTopSpeed = 20.0f;
	public float shipSpeed = 0;

	// Update is called once per frame
	void Update () 
	{
		CharacterController controller = GetComponent<CharacterController>();
		controller.Move (transform.forward * shipSpeed * Time.deltaTime);

		//Speed Up
		if(Input.GetKey(KeyCode.W))
		{
			if(shipSpeed < shipTopSpeed)
			{
				shipSpeed += 0.2f;
			}
			if(shipSpeed > shipTopSpeed)
			{
				shipSpeed = shipTopSpeed;
			}
		}

		//Slow Down
		if(Input.GetKey(KeyCode.S))
		{
			if(shipSpeed > -shipTopSpeed)
			{
				shipSpeed -= 0.3f;
				if(shipSpeed < -shipTopSpeed)
				{
					shipSpeed = -shipTopSpeed;
				}
			}
		}


	}
}
