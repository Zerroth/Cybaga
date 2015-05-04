using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour 
{
	public void LoadMainMenu()  //Method created for UI, when the Main Menu button is clicked, Main Menu is loaded
	{
		Application.LoadLevel("MainMenu");
	}
}
