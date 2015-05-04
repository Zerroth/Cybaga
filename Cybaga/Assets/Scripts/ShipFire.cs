using UnityEngine;
using System.Collections;

public class ShipFire : MonoBehaviour 
{
	public GameObject fireballBullet;
	public GameObject[] bulletSpawners = new GameObject[2];

	int weaponNumber = 1;
	public AudioClip fireSound; //audio for firing
	AudioSource audio; //used for playing the audio
	//public GameObject bsp1;
	//public GameObject bsp2;

	void Start()
	{
		audio = GetComponent<AudioSource>(); //audio is assigned the component of audio
		//bsp1 = gameObject.Find("WeaponSpawnerL");
		//bsp2 = gameObject.Find("WeaponSpawnerR");
	}


	void Update () 
	{

		if(Application.loadedLevel == 1)
		{
			Cursor.visible = false; //Makes curos invisible while playing
		}
		else
		{
			Cursor.visible = true;
		}
		if( Input.GetMouseButtonDown(0)) //if the left button was clicked
		{
			if( weaponNumber == 1) //Initially had 2 weapons on left and right, but the gameplay was too weak. One weapon shooting in the centre is enough
			{
				//Instantiate the bullet explicitly casted at a game object
				GameObject bulletSingleFire = Instantiate(fireballBullet,bulletSpawners[1].transform.position, Quaternion.identity) as GameObject; 
				//rb access the rigidbody
				Rigidbody rb = bulletSingleFire.GetComponent<Rigidbody>();
				//Shoots the ball forward multiplied by 2000
				rb.AddForce (transform.forward * 2000);
				audio.Stop();//Stops the previous sound
				audio.PlayOneShot(fireSound); //Plays the shot sound
			}
			/*
			else if(weaponNumber == 2)
			{

				for(int i = 0; i < 2; i++)
				{
					GameObject bulletDoubleFire = Instantiate(fireballBullet,bulletSpawners[i].transform.position, Quaternion.identity) as GameObject;
					Rigidbody rb1 = bulletDoubleFire.GetComponent<Rigidbody>();
					rb1.AddForce (transform.forward * 1000);
					audio.Stop();
					audio.PlayOneShot(fireSound);
				}
			}
			*/
		}



		if(Input.GetKeyUp(KeyCode.Alpha1))
		{
			weaponNumber = 1;
		}
		/*
		if(Input.GetKeyUp(KeyCode.Alpha2))
		{
			weaponNumber = 2;
		}
		*/
	}
}
